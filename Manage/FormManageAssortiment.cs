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

        #region From
        public FormManageAssortiment()
        {
            InitializeComponent();
            
        }

        private void FormManageAssortiment_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DataTable dt = dbo.GetAllCategories();
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "spCategory";

            GetGrid();
        }
        #endregion

        #region Buttons
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
            DataRowView dgvRowData = (DataRowView)dgvAssortiment.SelectedRows[0].DataBoundItem;
            DataRow row = (DataRow)dgvRowData.Row;

            FormManageArticle myForm = FormManageArticle.GetInstance();
            myForm.SetArticle(row);
            myForm.Show();
        }

        private void txtSearchAssortiment_TextChanged(object sender, EventArgs e)
        {
            dtGrid.DefaultView.RowFilter = String.Format($"asstArticleNumber LIKE '%{txtSearchAssortiment.Text}%' OR asstArticleDescription LIKE '%{txtSearchAssortiment.Text}%'");
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView dgvRowData = (DataRowView)dgvAssortiment.SelectedRows[0].DataBoundItem;
            DataRow row = (DataRow)dgvRowData.Row;

            string artNr = row[0].ToString();
            string artDesc = row[1].ToString();

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
        #endregion

        #region Functions
        public void GetGrid()
        {
            string cat = cboCategory.Text;

            try
            {
                dtGrid = dbo.GetArticle(cat);
                dgvAssortiment.DataSource = dtGrid;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            GetGrid();
        }
    }
}
