using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage;
using Order;

namespace OrderSystem
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        #region Functions
        void LaunchScreen(Form frm)
        {
            this.gboMenu.Visible = false;
            Application.DoEvents();
            frm.MdiParent = this;
            frm.FormClosed += new FormClosedEventHandler(ShowMenu);
            frm.Show();
        }

        void ShowMenu(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length <= 1)
            {
                this.gboMenu.Visible = true;
            }
        }
        #endregion

        #region Link clicked
        //  [MANAGE]
        //      Assortiment
        private void lnkManage_Assortiment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Assortiment();
        }

        private void assortimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assortiment();
        }


        //  [ORDER]
        //      Orders
        private void lnkManage_Orders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Orders();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders();
        }
        #endregion

        #region Redirect Form
        private void Assortiment()
        {
            FormManageAssortiment frm = FormManageAssortiment.GetInstance();
            this.LaunchScreen(frm);
        }

        private void Orders()
        {
            FormManageOrders frm = FormManageOrders.GetInstance();
            this.LaunchScreen(frm);
        }
        #endregion
    }
}
