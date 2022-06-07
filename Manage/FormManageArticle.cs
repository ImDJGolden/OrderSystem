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
        string price = "";

        bool edit = false;
        #endregion

        #region Form Generated Code
        public FormManageArticle()
        {
            InitializeComponent();
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
                    category = cboCategory.SelectedText;
                    price = txtPrice.Text;

                    try
                    {
                        dt = dbo.GetAllArticleNumbers();

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["asstArticleNumber"].ToString() == artNr)
                            {
                                artNrExists = true;
                            }
                        }


                        if (!artNrExists)
                        {
                            if (edit)
                            {
                                //EDIT db record
                                if (dbo.UpdateArticle(prevArtNr, artNr, artDesc, category, price))
                                {
                                    MessageBox.Show($"Article: '{artNr}' has been succesfully updated.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    edit = false;
                                }
                                else { MessageBox.Show($"An Error has occurd while updating Article '{artNr}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            else
                            {
                                //INSERT new db record
                                if (dbo.AddArticle(artNr, artDesc, category))
                                {
                                    if (dbo.UpdateArticle(artNr, price))
                                    {
                                        MessageBox.Show($"Article: '{artNr}' has been succesfully added.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion

        #region Functions
        public void SetArticle(DataRow row)
        {
            artNr = row[""].ToString();
            artDesc = row[""].ToString();
            category = row[""].ToString();
            price = row[""].ToString();

            this.txtArticleNr.Text = artNr;
            this.txtArticleDesc.Text = artDesc;
            this.cboCategory.Text = category;
            this.txtPrice.Text = price;

            edit = true;
        }
        #endregion
    }
}
