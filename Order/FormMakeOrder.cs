using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class FormMakeOrder : Form
    {
        #region Variables
        bool edit = false;
        #endregion

        #region Form
        public FormMakeOrder()
        {
            InitializeComponent();
        }
        #endregion

        #region Functions
        public void setOrder(DataRow row)
        {


            edit = true;
        }
        #endregion
    }
}
