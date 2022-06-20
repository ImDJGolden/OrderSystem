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
    public partial class FormManageOrders : Form
    {
        DBOrderSystem dbo = new DBOrderSystem();
        DataTable dtGrid = new DataTable();

        bool load = true;

        #region Form
        public FormManageOrders()
        {
            InitializeComponent();
        }

        private void FormManageOrders_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            DataTable dt = new DataTable();
            dt = dbo.GetCategories();
            cboCategory.DataSource = dt;
            this.cboCategory.DisplayMember = "spCategory";

            GetGrid();
            load = false;
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetGrid();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }


        private void txtOrderNr_TextChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                GetGrid();
            }
        }

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                GetGrid();
            }
        }

        private void rbtStatus_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton x = (RadioButton)sender;

            if (x.Checked)
            {
                switch (x.Name)
                {
                    case "rbtStatusTodo":
                        GetGrid("Todo");
                        break;

                    case "rbtStatusBusy":
                        GetGrid("Busy");
                        break;

                    case "rbtStatusDone":
                        GetGrid("Done");
                        break;

                    case "rbtStatusAll":
                    default:
                        GetGrid();
                        break;
                }
            }
        }
        #endregion

        #region Functions
        public void GetGrid()
        {
            string cat = "";
            string orderNr = "";

            if (load)
            {
                cat = "-- Default --";
            }
            else
            {
                cat = cboCategory.Text;
                orderNr = txtOrderNr.Text;
            }

            try
            {
                dtGrid = dbo.GetOrders(orderNr, cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetGrid(string s)
        {
            string cat = cboCategory.Text;
            string orderNr = txtOrderNr.Text;
            string status = s;


        }
        #endregion
    }
}
