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

            GetGrid();
            load = false;
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Functions
        public void GetGrid()
        {
            if (load)
            {

            }
        }
        #endregion
    }
}
