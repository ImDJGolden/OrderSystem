using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBControl;

namespace Order
{
    public partial class FormMakeOrder : Form
    {
        #region Variables
        DBOrderSystem dbo = new DBOrderSystem();
        DataTable dtAsst = new DataTable();
        DataTable dtOrder = new DataTable();    

        bool edit = false;
        bool load = true;

        #endregion

        #region Form
        public FormMakeOrder()
        {
            InitializeComponent();
        }

        private void FormMakeOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbo.GetCategories();
            cboCategory.DataSource = dt;
            this.cboCategory.DisplayMember = "spCategory";

            GetGridAsst();
            load = false;
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                GetGridAsst();
            }
        }
        #endregion

        #region Functions
        public void setOrder(DataRow row)
        {


            edit = true;
        }

        public void GetGridAsst()
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
            }

            try
            {
                dtAsst = dbo.GetArticle(cat, subCat);
                dgvAssortiment.DataSource = dtAsst;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
