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
    public partial class FormManageAddCategory : Form
    {
        DBOrderSystem dbo = new DBOrderSystem();

        #region Form
        public FormManageAddCategory()
        {
            InitializeComponent();
        }
        #endregion

        #region button
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bool catExists = false;
            string categoryName = txtCategory.Text;

            try
            {
                dt = dbo.GetAllCategories();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["spCategory"].ToString().ToLower() == categoryName.ToLower())
                    {
                        catExists = true;
                    }
                }

                if (!catExists)
                {
                    if (dbo.AddCategory(categoryName))
                    {
                        MessageBox.Show($"Category: '{categoryName}' has been succesfully added.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtCategory.Text = "";
                    }
                    else { MessageBox.Show($"An Error has occurd while adding category: '{categoryName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else 
                { 
                    MessageBox.Show($"Category: '{categoryName}' already exists. Try another name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCategory.Text = "";
                    catExists = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
