namespace OrderSystem
{
    partial class FormMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboMenu = new System.Windows.Forms.GroupBox();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.gboOrder = new System.Windows.Forms.GroupBox();
            this.lnkManage_Orders = new System.Windows.Forms.LinkLabel();
            this.gboManage = new System.Windows.Forms.GroupBox();
            this.lnkManage_Assortiment = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assortimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboMenu.SuspendLayout();
            this.gboOrder.SuspendLayout();
            this.gboManage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboMenu
            // 
            this.gboMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboMenu.Controls.Add(this.lblMenuTitle);
            this.gboMenu.Controls.Add(this.gboOrder);
            this.gboMenu.Controls.Add(this.gboManage);
            this.gboMenu.Location = new System.Drawing.Point(525, 140);
            this.gboMenu.Name = "gboMenu";
            this.gboMenu.Size = new System.Drawing.Size(425, 310);
            this.gboMenu.TabIndex = 0;
            this.gboMenu.TabStop = false;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblMenuTitle.Location = new System.Drawing.Point(6, 16);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(413, 23);
            this.lblMenuTitle.TabIndex = 2;
            this.lblMenuTitle.Text = "Order System";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboOrder
            // 
            this.gboOrder.Controls.Add(this.lnkManage_Orders);
            this.gboOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOrder.ForeColor = System.Drawing.Color.Orange;
            this.gboOrder.Location = new System.Drawing.Point(6, 157);
            this.gboOrder.Name = "gboOrder";
            this.gboOrder.Size = new System.Drawing.Size(413, 147);
            this.gboOrder.TabIndex = 1;
            this.gboOrder.TabStop = false;
            this.gboOrder.Text = "Order";
            // 
            // lnkManage_Orders
            // 
            this.lnkManage_Orders.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.lnkManage_Orders.AutoSize = true;
            this.lnkManage_Orders.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkManage_Orders.LinkColor = System.Drawing.Color.YellowGreen;
            this.lnkManage_Orders.Location = new System.Drawing.Point(6, 32);
            this.lnkManage_Orders.Name = "lnkManage_Orders";
            this.lnkManage_Orders.Size = new System.Drawing.Size(70, 16);
            this.lnkManage_Orders.TabIndex = 4;
            this.lnkManage_Orders.TabStop = true;
            this.lnkManage_Orders.Text = "1. Orders";
            this.lnkManage_Orders.VisitedLinkColor = System.Drawing.Color.GreenYellow;
            this.lnkManage_Orders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkManage_Orders_LinkClicked);
            // 
            // gboManage
            // 
            this.gboManage.Controls.Add(this.lnkManage_Assortiment);
            this.gboManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboManage.ForeColor = System.Drawing.Color.Orange;
            this.gboManage.Location = new System.Drawing.Point(6, 51);
            this.gboManage.Name = "gboManage";
            this.gboManage.Size = new System.Drawing.Size(413, 100);
            this.gboManage.TabIndex = 0;
            this.gboManage.TabStop = false;
            this.gboManage.Text = "Manage";
            // 
            // lnkManage_Assortiment
            // 
            this.lnkManage_Assortiment.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.lnkManage_Assortiment.AutoSize = true;
            this.lnkManage_Assortiment.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkManage_Assortiment.LinkColor = System.Drawing.Color.YellowGreen;
            this.lnkManage_Assortiment.Location = new System.Drawing.Point(6, 29);
            this.lnkManage_Assortiment.Name = "lnkManage_Assortiment";
            this.lnkManage_Assortiment.Size = new System.Drawing.Size(104, 16);
            this.lnkManage_Assortiment.TabIndex = 3;
            this.lnkManage_Assortiment.TabStop = true;
            this.lnkManage_Assortiment.Text = "1. Assortiment";
            this.lnkManage_Assortiment.VisitedLinkColor = System.Drawing.Color.GreenYellow;
            this.lnkManage_Assortiment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkManage_Assortiment_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assortimentToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // assortimentToolStripMenuItem
            // 
            this.assortimentToolStripMenuItem.Name = "assortimentToolStripMenuItem";
            this.assortimentToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.assortimentToolStripMenuItem.Text = "Assortiment";
            this.assortimentToolStripMenuItem.Click += new System.EventHandler(this.assortimentToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1440, 637);
            this.Controls.Add(this.gboMenu);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gboMenu.ResumeLayout(false);
            this.gboOrder.ResumeLayout(false);
            this.gboOrder.PerformLayout();
            this.gboManage.ResumeLayout(false);
            this.gboManage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gboMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.GroupBox gboOrder;
        private System.Windows.Forms.GroupBox gboManage;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.LinkLabel lnkManage_Assortiment;
        private System.Windows.Forms.ToolStripMenuItem assortimentToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkManage_Orders;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
    }
}

