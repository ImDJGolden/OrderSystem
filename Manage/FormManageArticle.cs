using DBControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage
{
    public partial class FormManageArticle : Form
    {
        #region Variables
        DBOrderSystem dbo = new DBOrderSystem();

        string artNr = "";
        string artDesc = "";
        string category = "";
        string subCategory = "";
        string price = "";

        bool edit = false;
        #endregion

        #region Form
        public FormManageArticle()
        {
            InitializeComponent();
        }

        private void FormManageArticle_Load(object sender, EventArgs e)
        {
            if (!edit)
            {
                DataTable dtCat = dbo.GetCategories();
                cboCategory.DataSource = dtCat;
                cboCategory.DisplayMember = "spCategory";

                DataTable dtSubCat = dbo.GetSubCategories(cboCategory.Text);
                this.cboSubCategory.DataSource = dtSubCat;
                this.cboSubCategory.DisplayMember = "spSubCategory";
            }
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtArticleNr.Text != "" && txtArticleDesc.Text != "" && txtPrice.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save the article", "Save Article", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    bool artNrExists = false;
                    string prevArtNr = artNr;

                    artNr = txtArticleNr.Text;
                    artDesc = txtArticleDesc.Text;
                    category = cboCategory.Text;
                    subCategory = cboSubCategory.Text;
                    price = txtPrice.Text;
                    price = price.Replace('.', ',');

                    try
                    {
                        dt = dbo.GetAllArticleNumbers();

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["asstArticleNumber"].ToString().ToLower() == artNr.ToLower())
                            {
                                artNrExists = true;

                                if (prevArtNr == artNr)
                                {
                                    artNrExists = false;
                                }
                            }
                        }

                        if (!artNrExists)
                        {
                            if (edit)
                            {
                                //EDIT db record
                                if (dbo.UpdateArticle(prevArtNr, artNr, artDesc, category, subCategory, price))
                                {
                                    MessageBox.Show($"Article: '{artNr}' has been succesfully updated.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    edit = false;

                                    FormManageAssortiment frm = FormManageAssortiment.GetInstance();
                                    frm.GetGrid();

                                    this.Close();
                                }
                                else { MessageBox.Show($"An Error has occurd while updating Article '{artNr}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            else
                            {
                                //INSERT new db record
                                if (dbo.AddArticle(artNr, artDesc, category, subCategory))
                                {
                                    if (dbo.UpdateArticle(artNr, price))
                                    {
                                        MessageBox.Show($"Article: '{artNr}' has been succesfully added.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        FormManageAssortiment frm = FormManageAssortiment.GetInstance();
                                        frm.GetGrid();

                                        this.Close();
                                    }
                                    else { MessageBox.Show($"An Error has occurd while adding Article '{artNr}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                }
                                else { MessageBox.Show($"An Error has occurd while adding Article '{artNr}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                        }
                        else { MessageBox.Show($"Article number: '{artNr}' already exists. Try another one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Empty fields are not allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            if (this.cboCategory.Text != "-- Default --")
            {
                DataTable dt = dbo.GetSubCategories(cboCategory.Text);
                this.cboSubCategory.DataSource = dt;
                this.cboSubCategory.DisplayMember = "spSubCategory";
            }
        }
        #endregion

        #region Functions
        public void SetArticle(DataRow row)
        {
            DataTable dt = dbo.GetCategories();
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "spCategory";

            artNr = row[1].ToString();
            artDesc = row[2].ToString();
            category = row[3].ToString();
            subCategory = row[4].ToString();
            price = row[5].ToString();

            this.txtArticleNr.Text = artNr;
            this.txtArticleDesc.Text = artDesc;
            this.cboCategory.SelectedIndex = cboCategory.FindStringExact(category);
            this.cboSubCategory.SelectedIndex = cboSubCategory.FindStringExact(subCategory);
            this.txtPrice.Text = price;

            edit = true;
        }
        #endregion
    }
}
