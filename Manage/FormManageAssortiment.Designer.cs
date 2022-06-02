namespace Manage
{
    partial class FormManageAssortiment
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

        public static FormManageAssortiment myForm = null;

        public static FormManageAssortiment GetInstance()
        {
            if (myForm == null)
            {
                myForm = new FormManageAssortiment();
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
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAssortiment = new System.Windows.Forms.DataGridView();
            this.txtSearchAssortiment = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssortiment)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnAddCategory);
            this.pnlCategory.Controls.Add(this.lblCategory);
            this.pnlCategory.Controls.Add(this.cboCategory);
            this.pnlCategory.Location = new System.Drawing.Point(13, 13);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(298, 31);
            this.pnlCategory.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(77, 3);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(137, 21);
            this.cboCategory.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1272, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(1174, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 63);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete item";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(1174, 167);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 63);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit item";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1174, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 63);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvAssortiment
            // 
            this.dgvAssortiment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssortiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssortiment.Location = new System.Drawing.Point(13, 98);
            this.dgvAssortiment.Name = "dgvAssortiment";
            this.dgvAssortiment.Size = new System.Drawing.Size(1155, 682);
            this.dgvAssortiment.TabIndex = 6;
            // 
            // txtSearchAssortiment
            // 
            this.txtSearchAssortiment.Location = new System.Drawing.Point(13, 72);
            this.txtSearchAssortiment.Name = "txtSearchAssortiment";
            this.txtSearchAssortiment.Size = new System.Drawing.Size(167, 20);
            this.txtSearchAssortiment.TabIndex = 5;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(220, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "+ Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // FormManageAssortiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 792);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAssortiment);
            this.Controls.Add(this.txtSearchAssortiment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlCategory);
            this.Name = "FormManageAssortiment";
            this.Text = "Manage - Assortiment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormManageAssortiment_Load);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssortiment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAssortiment;
        private System.Windows.Forms.TextBox txtSearchAssortiment;
        private System.Windows.Forms.Button btnAddCategory;
    }
}

