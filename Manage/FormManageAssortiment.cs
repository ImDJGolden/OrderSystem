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
            //TODO:
            //  Get DataRow from dgv.selectedrow
            FormManageArticle myForm = FormManageArticle.GetInstance();
            //myForm.SetArticle(row);
            myForm.Show();
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
    }
}
