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
        public FormManageAssortiment()
        {
            InitializeComponent();
            
        }

        private void FormManageAssortiment_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //TODO: Get categories from DBAssortiment for cboCategory
        }

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormManageAddCategory myForm = FormManageAddCategory.GetInstance();
            myForm.TopMost = true;
            myForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormManageArticle myForm = FormManageArticle.GetInstance();
            myForm.TopMost = true;
            myForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //TODO:
            //  Get DataRow from dgv.selectedrow
            FormManageArticle myForm = FormManageArticle.GetInstance();
            //myForm.SetArticle(row);
            myForm.TopMost = true;
            myForm.Show();
        }
        #endregion

    }
}
