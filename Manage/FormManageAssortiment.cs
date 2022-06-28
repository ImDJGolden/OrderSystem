using DBControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage
{
    public partial class FormManageAssortiment : Form
    {
        DBOrderSystem dbo = new DBOrderSystem();
        DataTable dtGrid = new DataTable();

        bool load = true;

        #region From
        public FormManageAssortiment()
        {
            InitializeComponent();
            
        }

        private void FormManageAssortiment_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.lblSubCategory.Visible = false;
            this.cboSubCategory.Visible = false;

            DataTable dt = dbo.GetCategories();
            this.cboCategory.DataSource = dt;
            this.cboCategory.DisplayMember = "spCategory";

            GetGrid();

            load = false;
        }
        #endregion

        #region Buttons
        //Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormManageAddCategory myForm = FormManageAddCategory.GetInstance();
            myForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormManageArticle myForm = FormManageArticle.GetInstance();
            myForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAssortiment.Rows.Count > 0)
            {
                DataRowView dgvRowData = (DataRowView)dgvAssortiment.SelectedRows[0].DataBoundItem;
                DataRow row = (DataRow)dgvRowData.Row;

                FormManageArticle myForm = FormManageArticle.GetInstance();
                myForm.SetArticle(row);
                myForm.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView dgvRowData = (DataRowView)dgvAssortiment.SelectedRows[0].DataBoundItem;
            DataRow row = (DataRow)dgvRowData.Row;

            string artNr = row[1].ToString();
            string artDesc = row[2].ToString();

            try
            {
                DialogResult res = MessageBox.Show($"Are you sure you want to delete Article: '{artNr} - {artDesc}'?", "Delete Article?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    if (dbo.DeleteArticle(artNr))
                    {
                        MessageBox.Show($"Article: '{artNr}' has been succesfully Deleted.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show($"An Error has occurd while Deleting Article '{artNr}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    GetGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //TextChanged
        private void txtSearchAssortiment_TextChanged(object sender, EventArgs e)
        {
            dtGrid.DefaultView.RowFilter = String.Format($"asstArticleNumber LIKE '%{txtSearchAssortiment.Text}%' OR asstArticleDescription LIKE '%{txtSearchAssortiment.Text}%'");
        }

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                GetGrid();
            }

            if (this.cboCategory.Text != "-- Default --")
            {
                this.lblSubCategory.Visible = true;
                this.cboSubCategory.Visible = true;

                DataTable dt = dbo.GetSubCategories(cboCategory.Text);
                this.cboSubCategory.DataSource = dt;
                this.cboSubCategory.DisplayMember = "spSubCategory";
            }
            else
            {
                this.lblSubCategory.Visible = false;
                this.cboSubCategory.Visible = false;
            }
        }

        private void cboSubCategory_TextChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                GetGrid();
            }
        }
        #endregion

        #region Functions

        public void GetGrid()
        {
            string cat = "";
            string subCat = "";

            if (load)
            {
                cat = "-- Default --";
            }
            else
            {
                cat = cboCategory.Text;
                subCat = cboSubCategory.Text;
            }

            try
            {
                dtGrid = dbo.GetArticle(cat, subCat);
                dgvAssortiment.DataSource = dtGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
