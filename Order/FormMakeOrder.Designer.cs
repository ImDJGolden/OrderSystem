﻿namespace Order
{
    partial class FormMakeOrder
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

        public static FormMakeOrder myForm = null;

        public static FormMakeOrder GetInstance()
        {
            if (myForm == null)
            {
                myForm = new FormMakeOrder();
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.dgvAssortiment = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlFilterAsst = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.artNr_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artDesc_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artPrice_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCat_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssortiment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.pnlFilterAsst.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(61, 9);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(155, 21);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.TextChanged += new System.EventHandler(this.cboCategory_TextChanged);
            // 
            // dgvAssortiment
            // 
            this.dgvAssortiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssortiment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.ArticleNr,
            this.ArticleDesc,
            this.Category,
            this.SubCategory,
            this.Price});
            this.dgvAssortiment.Location = new System.Drawing.Point(15, 74);
            this.dgvAssortiment.MultiSelect = false;
            this.dgvAssortiment.Name = "dgvAssortiment";
            this.dgvAssortiment.ReadOnly = true;
            this.dgvAssortiment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssortiment.Size = new System.Drawing.Size(625, 601);
            this.dgvAssortiment.TabIndex = 2;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "asstIndex";
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Visible = false;
            // 
            // ArticleNr
            // 
            this.ArticleNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArticleNr.DataPropertyName = "asstArticleNumber";
            this.ArticleNr.HeaderText = "Article Number";
            this.ArticleNr.Name = "ArticleNr";
            this.ArticleNr.ReadOnly = true;
            // 
            // ArticleDesc
            // 
            this.ArticleDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArticleDesc.DataPropertyName = "asstArticleDescription";
            this.ArticleDesc.HeaderText = "Article Description";
            this.ArticleDesc.Name = "ArticleDesc";
            this.ArticleDesc.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.DataPropertyName = "asstCategory";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // SubCategory
            // 
            this.SubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubCategory.DataPropertyName = "asstSubCategory";
            this.SubCategory.HeaderText = "Sub Category";
            this.SubCategory.Name = "SubCategory";
            this.SubCategory.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "asstPrice";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artNr_Order,
            this.artDesc_Order,
            this.artPrice_Order,
            this.cat_Order,
            this.subCat_Order,
            this.amount_Order,
            this.totalPrice_Order});
            this.dgvOrder.Location = new System.Drawing.Point(756, 74);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(761, 601);
            this.dgvOrder.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(646, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(646, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 45);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1442, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1442, 681);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 39);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(61, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(222, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlFilterAsst
            // 
            this.pnlFilterAsst.Controls.Add(this.lblCategory);
            this.pnlFilterAsst.Controls.Add(this.btnRefresh);
            this.pnlFilterAsst.Controls.Add(this.cboCategory);
            this.pnlFilterAsst.Controls.Add(this.txtSearch);
            this.pnlFilterAsst.Controls.Add(this.lblSearch);
            this.pnlFilterAsst.Location = new System.Drawing.Point(12, 5);
            this.pnlFilterAsst.Name = "pnlFilterAsst";
            this.pnlFilterAsst.Size = new System.Drawing.Size(301, 63);
            this.pnlFilterAsst.TabIndex = 11;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(753, 45);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(36, 13);
            this.lblOrder.TabIndex = 12;
            this.lblOrder.Text = "Order:";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(795, 42);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(143, 20);
            this.txtOrder.TabIndex = 13;
            // 
            // artNr_Order
            // 
            this.artNr_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artNr_Order.HeaderText = "Article Number";
            this.artNr_Order.Name = "artNr_Order";
            // 
            // artDesc_Order
            // 
            this.artDesc_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artDesc_Order.HeaderText = "Article Description";
            this.artDesc_Order.Name = "artDesc_Order";
            // 
            // artPrice_Order
            // 
            this.artPrice_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.artPrice_Order.HeaderText = "Article Price";
            this.artPrice_Order.Name = "artPrice_Order";
            // 
            // cat_Order
            // 
            this.cat_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cat_Order.HeaderText = "Category";
            this.cat_Order.Name = "cat_Order";
            // 
            // subCat_Order
            // 
            this.subCat_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subCat_Order.HeaderText = "Sub Category";
            this.subCat_Order.Name = "subCat_Order";
            // 
            // amount_Order
            // 
            this.amount_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount_Order.HeaderText = "Amount";
            this.amount_Order.Name = "amount_Order";
            // 
            // totalPrice_Order
            // 
            this.totalPrice_Order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice_Order.HeaderText = "Total";
            this.totalPrice_Order.Name = "totalPrice_Order";
            // 
            // FormMakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 716);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.pnlFilterAsst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.dgvAssortiment);
            this.Name = "FormMakeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMakeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssortiment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.pnlFilterAsst.ResumeLayout(false);
            this.pnlFilterAsst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.DataGridView dgvAssortiment;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlFilterAsst;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn artNr_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn artDesc_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn artPrice_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCat_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice_Order;
    }
}