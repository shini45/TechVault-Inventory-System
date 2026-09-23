namespace TechVault.Inventory
{
    partial class TechVault
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
            txtUnitPrice = new TextBox();
            label1 = new Label();
            name = new Label();
            code = new Label();
            brand = new Label();
            unitPrice = new Label();
            groupBox1 = new GroupBox();
            txtStockQuantity = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label2 = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            txtBrand = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvItems = new DataGridView();
            btnClear = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnAdvancedStockOut = new Button();
            btnAdvancedStockIn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = Color.White;
            txtUnitPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.ForeColor = Color.FromArgb(45, 35, 60);
            txtUnitPrice.Location = new Point(122, 167);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(358, 30);
            txtUnitPrice.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(90, 60, 120);
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 41);
            label1.TabIndex = 1;
            label1.Text = "TechVault Inventory System";
            label1.Click += label1_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(6, 41);
            name.Name = "name";
            name.Size = new Size(73, 28);
            name.TabIndex = 2;
            name.Text = "Name:";
            // 
            // code
            // 
            code.AutoSize = true;
            code.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            code.Location = new Point(6, 83);
            code.Name = "code";
            code.Size = new Size(64, 28);
            code.TabIndex = 3;
            code.Text = "Code:";
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brand.Location = new Point(6, 124);
            brand.Name = "brand";
            brand.Size = new Size(73, 28);
            brand.TabIndex = 4;
            brand.Text = "Brand:";
            brand.Click += label4_Click;
            // 
            // unitPrice
            // 
            unitPrice.AutoSize = true;
            unitPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unitPrice.Location = new Point(6, 166);
            unitPrice.Name = "unitPrice";
            unitPrice.Size = new Size(110, 28);
            unitPrice.TabIndex = 5;
            unitPrice.Text = "Unit Price:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(250, 247, 255);
            groupBox1.Controls.Add(txtStockQuantity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(unitPrice);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(code);
            groupBox1.Controls.Add(brand);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(126, 87, 194);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(947, 221);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Information";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.BackColor = Color.White;
            txtStockQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQuantity.ForeColor = Color.FromArgb(45, 35, 60);
            txtStockQuantity.Location = new Point(679, 124);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(230, 30);
            txtStockQuantity.TabIndex = 12;
            txtStockQuantity.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(515, 130);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 11;
            label3.Text = "Stock Quantity:";
            label3.Click += label3_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = Color.FromArgb(45, 35, 60);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(679, 36);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(230, 31);
            cmbCategory.TabIndex = 10;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(515, 44);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 9;
            label2.Text = "Category:";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(45, 35, 60);
            txtName.Location = new Point(122, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(358, 30);
            txtName.TabIndex = 8;
            txtName.UseWaitCursor = true;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.ForeColor = Color.FromArgb(45, 35, 60);
            txtCode.Location = new Point(122, 77);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(358, 30);
            txtCode.TabIndex = 7;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.White;
            txtBrand.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.ForeColor = Color.FromArgb(45, 35, 60);
            txtBrand.Location = new Point(122, 121);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(358, 30);
            txtBrand.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(149, 117, 205);
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(93, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(149, 117, 205);
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(202, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(149, 117, 205);
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(329, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button3_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(149, 117, 205);
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(441, 310);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh List";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += button4_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItems.BackgroundColor = Color.FromArgb(250, 247, 255);
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(44, 417);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.RowTemplate.Height = 30;
            dgvItems.ScrollBars = ScrollBars.Vertical;
            dgvItems.Size = new Size(877, 258);
            dgvItems.TabIndex = 11;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(149, 117, 205);
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(552, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button1_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(267, 358);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(480, 27);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(126, 87, 194);
            lblSearch.Location = new Point(202, 362);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 14;
            lblSearch.Text = "Search:";
            lblSearch.Click += label4_Click_1;
            // 
            // btnAdvancedStockOut
            // 
            btnAdvancedStockOut.BackColor = Color.FromArgb(149, 117, 205);
            btnAdvancedStockOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdvancedStockOut.ForeColor = Color.White;
            btnAdvancedStockOut.Location = new Point(780, 310);
            btnAdvancedStockOut.Name = "btnAdvancedStockOut";
            btnAdvancedStockOut.Size = new Size(102, 29);
            btnAdvancedStockOut.TabIndex = 15;
            btnAdvancedStockOut.Text = "- Stock Out";
            btnAdvancedStockOut.UseVisualStyleBackColor = false;
            btnAdvancedStockOut.Click += btnAdvancedStockOut_Click_1;
            // 
            // btnAdvancedStockIn
            // 
            btnAdvancedStockIn.BackColor = Color.FromArgb(149, 117, 205);
            btnAdvancedStockIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdvancedStockIn.ForeColor = Color.White;
            btnAdvancedStockIn.Location = new Point(661, 310);
            btnAdvancedStockIn.Name = "btnAdvancedStockIn";
            btnAdvancedStockIn.Size = new Size(102, 29);
            btnAdvancedStockIn.TabIndex = 16;
            btnAdvancedStockIn.Text = "+ Stock In";
            btnAdvancedStockIn.UseVisualStyleBackColor = false;
            btnAdvancedStockIn.Click += btnAdvancedStockIn_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 240, 255);
            ClientSize = new Size(972, 705);
            Controls.Add(btnAdvancedStockIn);
            Controls.Add(btnAdvancedStockOut);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(dgvItems);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TechVault Inventory System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnitPrice;
        private Label label1;
        private Label name;
        private Label code;
        private Label brand;
        private Label unitPrice;
        private GroupBox groupBox1;
        private TextBox txtName;
        private TextBox txtCode;
        private TextBox txtBrand;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvItems;
        private Button btnClear;
        private Label label2;
        private Label label3;
        private ComboBox cmbCategory;
        private TextBox txtStockQuantity;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnAdvancedStockOut;
        private Button btnAdvancedStockIn;
    }
}