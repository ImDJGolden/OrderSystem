namespace Order
{
    partial class FormManageOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

        public static FormManageOrders myForm = null;

        public static FormManageOrders GetInstance()
        {
            if (myForm == null)
            {
                myForm = new FormManageOrders();
            }
            myForm.BringToFront();
            return myForm;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            myForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.rbtStatusTodo = new System.Windows.Forms.RadioButton();
            this.rbtStatusBusy = new System.Windows.Forms.RadioButton();
            this.rbtStatusDone = new System.Windows.Forms.RadioButton();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(1054, 141);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(94, 45);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Add order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(1154, 141);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(94, 45);
            this.btnEditOrder.TabIndex = 1;
            this.btnEditOrder.Text = "Edit order";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(1254, 141);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(94, 45);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Delete order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 192);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(1336, 538);
            this.dgvOrders.TabIndex = 4;
            // 
            // rbtStatusTodo
            // 
            this.rbtStatusTodo.AutoSize = true;
            this.rbtStatusTodo.Location = new System.Drawing.Point(3, 3);
            this.rbtStatusTodo.Name = "rbtStatusTodo";
            this.rbtStatusTodo.Size = new System.Drawing.Size(50, 17);
            this.rbtStatusTodo.TabIndex = 5;
            this.rbtStatusTodo.TabStop = true;
            this.rbtStatusTodo.Text = "Todo";
            this.rbtStatusTodo.UseVisualStyleBackColor = true;
            // 
            // rbtStatusBusy
            // 
            this.rbtStatusBusy.AutoSize = true;
            this.rbtStatusBusy.Location = new System.Drawing.Point(3, 26);
            this.rbtStatusBusy.Name = "rbtStatusBusy";
            this.rbtStatusBusy.Size = new System.Drawing.Size(48, 17);
            this.rbtStatusBusy.TabIndex = 6;
            this.rbtStatusBusy.TabStop = true;
            this.rbtStatusBusy.Text = "Busy";
            this.rbtStatusBusy.UseVisualStyleBackColor = true;
            // 
            // rbtStatusDone
            // 
            this.rbtStatusDone.AutoSize = true;
            this.rbtStatusDone.Location = new System.Drawing.Point(3, 49);
            this.rbtStatusDone.Name = "rbtStatusDone";
            this.rbtStatusDone.Size = new System.Drawing.Size(51, 17);
            this.rbtStatusDone.TabIndex = 7;
            this.rbtStatusDone.TabStop = true;
            this.rbtStatusDone.Text = "Done";
            this.rbtStatusDone.UseVisualStyleBackColor = true;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.rbtStatusTodo);
            this.pnlStatus.Controls.Add(this.rbtStatusDone);
            this.pnlStatus.Controls.Add(this.rbtStatusBusy);
            this.pnlStatus.Location = new System.Drawing.Point(12, 117);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(94, 69);
            this.pnlStatus.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(133, 168);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(183, 165);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(289, 163);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1273, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(70, 6);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(142, 21);
            this.cboCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category:";
            // 
            // FormManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 742);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Name = "FormManageOrders";
            this.Text = "Manage - Orders";
            this.Load += new System.EventHandler(this.FormManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.RadioButton rbtStatusTodo;
        private System.Windows.Forms.RadioButton rbtStatusBusy;
        private System.Windows.Forms.RadioButton rbtStatusDone;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
    }
}

