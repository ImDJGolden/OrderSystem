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
            this.gboOrder = new System.Windows.Forms.GroupBox();
            this.lnkOrder_Broodjes = new System.Windows.Forms.LinkLabel();
            this.gboManage = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.broodjesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.gboMenu.SuspendLayout();
            this.gboOrder.SuspendLayout();
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
            // gboOrder
            // 
            this.gboOrder.Controls.Add(this.lnkOrder_Broodjes);
            this.gboOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOrder.ForeColor = System.Drawing.Color.Orange;
            this.gboOrder.Location = new System.Drawing.Point(6, 157);
            this.gboOrder.Name = "gboOrder";
            this.gboOrder.Size = new System.Drawing.Size(413, 147);
            this.gboOrder.TabIndex = 1;
            this.gboOrder.TabStop = false;
            this.gboOrder.Text = "Order";
            // 
            // lnkOrder_Broodjes
            // 
            this.lnkOrder_Broodjes.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.lnkOrder_Broodjes.AutoSize = true;
            this.lnkOrder_Broodjes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkOrder_Broodjes.LinkColor = System.Drawing.Color.YellowGreen;
            this.lnkOrder_Broodjes.Location = new System.Drawing.Point(6, 28);
            this.lnkOrder_Broodjes.Name = "lnkOrder_Broodjes";
            this.lnkOrder_Broodjes.Size = new System.Drawing.Size(86, 16);
            this.lnkOrder_Broodjes.TabIndex = 0;
            this.lnkOrder_Broodjes.TabStop = true;
            this.lnkOrder_Broodjes.Text = "1. Broodjes";
            this.lnkOrder_Broodjes.VisitedLinkColor = System.Drawing.Color.GreenYellow;
            // 
            // gboManage
            // 
            this.gboManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboManage.ForeColor = System.Drawing.Color.Orange;
            this.gboManage.Location = new System.Drawing.Point(6, 51);
            this.gboManage.Name = "gboManage";
            this.gboManage.Size = new System.Drawing.Size(413, 100);
            this.gboManage.TabIndex = 0;
            this.gboManage.TabStop = false;
            this.gboManage.Text = "Manage";
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
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.broodjesToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // broodjesToolStripMenuItem
            // 
            this.broodjesToolStripMenuItem.Name = "broodjesToolStripMenuItem";
            this.broodjesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.broodjesToolStripMenuItem.Text = "Broodjes";
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
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1440, 637);
            this.Controls.Add(this.gboMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "Order System";
            this.gboMenu.ResumeLayout(false);
            this.gboOrder.ResumeLayout(false);
            this.gboOrder.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem broodjesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gboOrder;
        private System.Windows.Forms.GroupBox gboManage;
        private System.Windows.Forms.LinkLabel lnkOrder_Broodjes;
        private System.Windows.Forms.Label lblMenuTitle;
    }
}

