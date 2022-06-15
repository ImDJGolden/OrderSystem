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
        DataTable dt = new DataTable();

        #region Form
        public FormManageAddCategory()
        {
            InitializeComponent();
        }

        private void FormManageAddCategory_Load(object sender, EventArgs e)
        {
            try
            {
                dt = dbo.GetAllCategories();

                dgvCategories.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region button
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtdb = dbo.GetAllCategories();

            bool exists = false;
            string cat = "";
            string subCat = "";

            try
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    cat = dt.Rows[i]["spCategory"].ToString();
                    subCat = dt.Rows[i]["spSubCategory"].ToString();

                    bool contains = dtdb.AsEnumerable().Where(c => c.Field<string>("spCategory").Equals(cat)).Count() > 0;

                    if (contains)
                    {
                        contains = dtdb.AsEnumerable().Where(c => c.Field<string>("spSubCategory").Equals(subCat)).Count() > 0;

                        if (contains)
                        {
                            exists = true; 
                        }
                        else
                        {
                            if (dbo.AddCategory(cat, subCat))
                            {
                                MessageBox.Show($"Category has been succesfully added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FormManageAddCategory_Load(sender, e);
                            }
                            else 
                            {
                                MessageBox.Show($"An error occurd while adding the category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        if (dbo.AddCategory(cat, subCat))
                        {
                            MessageBox.Show($"Category has been succesfully added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FormManageAddCategory_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show($"An error occurd while adding the category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (exists)
                {
                    MessageBox.Show($"All categories already exists in the database", "Already exists.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    exists = false;
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
