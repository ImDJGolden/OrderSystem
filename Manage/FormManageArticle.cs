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
    public partial class FormManageArticle : Form
    {
        public FormManageArticle()
        {
            InitializeComponent();
        }

        #region Functions
        public void SetArticle(DataRow row)
        {
            string artNr = row[""].ToString();
            string artDesc = row[""].ToString();
            double price = Convert.ToDouble(row[""]);

            this.txtArticleNr.Text = artNr;
            this.txtArticleDesc.Text = artDesc;
            this.cboCategory.Text = row[""].ToString();
            this.txtPrice.Text = price.ToString();
        }
        #endregion
    }
}
