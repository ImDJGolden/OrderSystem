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

        string category = "";
        string subCategory = "";
        string artNr = "";
        string artDesc = "";
        int amount = 0;
        double artPrice = 0;
        double totalPrice = 0;
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

            GetGridOrder();
            GetGridAsst();

            load = false;

            if (!edit)
            {
                CreateOrderNumber();
            }
        }
        #endregion

        #region Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)dgvAssortiment.Rows[0].DataBoundItem;
            DataRow dataRow = (DataRow)dataRowView.Row;

            string x = "";

            category = dataRow[3].ToString();
            subCategory = dataRow[4].ToString();
            artNr = dataRow[1].ToString();
            artDesc = dataRow[2].ToString();
            artPrice = Convert.ToDouble(dataRow[5]);

            bool checkOrder = dtOrder.AsEnumerable().Where(c => c.Field<string>("oddArticleNr").Equals(artNr)).Count() > 0;

            if (!checkOrder)
            {
                //Not found : Add
                dtOrder.Rows.Add("OrderNr here", category, subCategory, artNr, artDesc, amount, artPrice, totalPrice);
            }
            else
            {
                //Found     : Edit
                DataRow row = dtOrder.Select($"oddArticleNr = {artNr}").FirstOrDefault();

                row["oddAmount"] = Convert.ToInt32(row["oddAmount"]) + 1;
                row["oddTotalPrice"] = artPrice * Convert.ToInt32(row["oddAmount"]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetGridAsst();
        }

        private void cboCategory_TextChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                GetGridAsst();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtAsst.DefaultView.RowFilter = String.Format($"asstArticleNumber LIKE '%{txtSearch.Text}%' OR asstArticleDescription LIKE '%{txtSearch.Text}%'");
        }
        #endregion

        #region Functions
        public void setOrder(DataRow row)
        {
            //Edit order

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

        public void GetGridOrder()
        {
            dtOrder.Columns.Add("oddOrderNr", typeof(string));
            dtOrder.Columns.Add("oddCategory", typeof(string));
            dtOrder.Columns.Add("oddSubCategory", typeof(string));
            dtOrder.Columns.Add("oddArticleNr", typeof(string));
            dtOrder.Columns.Add("oddArticleDesc", typeof(string));
            dtOrder.Columns.Add("oddAmount", typeof(int));
            dtOrder.Columns.Add("oddArticlePrice", typeof(double));
            dtOrder.Columns.Add("oddTotalPrice", typeof(double));

            if (edit)
            {
                //Get dt all orderdetails via string ordernr
                DataTable dt = new DataTable();
            }
        }

        public void CreateOrderNumber()
        {
            //Get dt all ordernumbers, and add 1 to last number
            DataTable dt = new DataTable();
        }
        #endregion
    }
}
