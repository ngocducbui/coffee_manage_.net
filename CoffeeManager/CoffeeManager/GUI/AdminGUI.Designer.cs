
namespace CoffeeManager.GUI
{
    partial class AdminGUI
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
            this.tpTable = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDCategory = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboCategoryProduct = new System.Windows.Forms.ComboBox();
            this.nmPriceProducts = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductsName = new System.Windows.Forms.TextBox();
            this.txtNameProducts = new System.Windows.Forms.Label();
            this.txtProductsID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProdcuts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nmTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDisplayNameAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUserNameAccount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtgvAccounts = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tpTable.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.tpCategory.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel14.SuspendLayout();
            this.tpProduct.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceProducts)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.tpAccounts.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.tpBill);
            this.tpTable.Controls.Add(this.tpCategory);
            this.tpTable.Controls.Add(this.tpProduct);
            this.tpTable.Controls.Add(this.tpAccounts);
            this.tpTable.Location = new System.Drawing.Point(12, 12);
            this.tpTable.Name = "tpTable";
            this.tpTable.SelectedIndex = 0;
            this.tpTable.Size = new System.Drawing.Size(787, 435);
            this.tpTable.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.btnSearch);
            this.tpBill.Controls.Add(this.label2);
            this.tpBill.Controls.Add(this.label1);
            this.tpBill.Controls.Add(this.dtpkToDate);
            this.tpBill.Controls.Add(this.dtpkFromDate);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 28);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(779, 403);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Turnover";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(673, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(399, 15);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(240, 26);
            this.dtpkToDate.TabIndex = 2;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(79, 15);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(240, 26);
            this.dtpkFromDate.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 346);
            this.panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(0, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 49;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(763, 340);
            this.dtgvBill.TabIndex = 0;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.panel16);
            this.tpCategory.Controls.Add(this.panel15);
            this.tpCategory.Controls.Add(this.panel14);
            this.tpCategory.Location = new System.Drawing.Point(4, 28);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(779, 403);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Categorys";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtNameCategory);
            this.panel16.Controls.Add(this.label15);
            this.panel16.Controls.Add(this.txtIDCategory);
            this.panel16.Controls.Add(this.label14);
            this.panel16.Location = new System.Drawing.Point(418, 95);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(337, 302);
            this.panel16.TabIndex = 2;
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(114, 65);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(189, 26);
            this.txtNameCategory.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(13, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Name:";
            // 
            // txtIDCategory
            // 
            this.txtIDCategory.Location = new System.Drawing.Point(114, 12);
            this.txtIDCategory.Name = "txtIDCategory";
            this.txtIDCategory.ReadOnly = true;
            this.txtIDCategory.Size = new System.Drawing.Size(189, 26);
            this.txtIDCategory.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(13, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "ID:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dtgvCategory);
            this.panel15.Location = new System.Drawing.Point(6, 95);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(380, 302);
            this.panel15.TabIndex = 1;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 12);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 49;
            this.dtgvCategory.RowTemplate.Height = 28;
            this.dtgvCategory.Size = new System.Drawing.Size(374, 287);
            this.dtgvCategory.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnViewCategory);
            this.panel14.Controls.Add(this.btnDeleteCategory);
            this.panel14.Controls.Add(this.btnUpdateCategory);
            this.panel14.Controls.Add(this.btnAddCategory);
            this.panel14.Location = new System.Drawing.Point(192, 16);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(380, 62);
            this.panel14.TabIndex = 0;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.BackColor = System.Drawing.Color.FloralWhite;
            this.btnViewCategory.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewCategory.Location = new System.Drawing.Point(276, 14);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(85, 45);
            this.btnViewCategory.TabIndex = 6;
            this.btnViewCategory.Text = "View";
            this.btnViewCategory.UseVisualStyleBackColor = false;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteCategory.Location = new System.Drawing.Point(185, 14);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(85, 45);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUpdateCategory.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateCategory.Location = new System.Drawing.Point(94, 14);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(85, 45);
            this.btnUpdateCategory.TabIndex = 4;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCategory.Location = new System.Drawing.Point(3, 14);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(85, 45);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.panel5);
            this.tpProduct.Controls.Add(this.panel4);
            this.tpProduct.Controls.Add(this.panel3);
            this.tpProduct.Controls.Add(this.panel2);
            this.tpProduct.Location = new System.Drawing.Point(4, 28);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(779, 403);
            this.tpProduct.TabIndex = 4;
            this.tpProduct.Text = "Products";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboCategoryProduct);
            this.panel5.Controls.Add(this.nmPriceProducts);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtProductsName);
            this.panel5.Controls.Add(this.txtNameProducts);
            this.panel5.Controls.Add(this.txtProductsID);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(420, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 323);
            this.panel5.TabIndex = 3;
            // 
            // cboCategoryProduct
            // 
            this.cboCategoryProduct.FormattingEnabled = true;
            this.cboCategoryProduct.Location = new System.Drawing.Point(117, 115);
            this.cboCategoryProduct.Name = "cboCategoryProduct";
            this.cboCategoryProduct.Size = new System.Drawing.Size(220, 27);
            this.cboCategoryProduct.TabIndex = 8;
            // 
            // nmPriceProducts
            // 
            this.nmPriceProducts.Location = new System.Drawing.Point(117, 166);
            this.nmPriceProducts.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmPriceProducts.Name = "nmPriceProducts";
            this.nmPriceProducts.Size = new System.Drawing.Size(220, 26);
            this.nmPriceProducts.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // txtProductsName
            // 
            this.txtProductsName.Location = new System.Drawing.Point(117, 60);
            this.txtProductsName.Name = "txtProductsName";
            this.txtProductsName.Size = new System.Drawing.Size(220, 26);
            this.txtProductsName.TabIndex = 3;
            // 
            // txtNameProducts
            // 
            this.txtNameProducts.AutoSize = true;
            this.txtNameProducts.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameProducts.Location = new System.Drawing.Point(3, 61);
            this.txtNameProducts.Name = "txtNameProducts";
            this.txtNameProducts.Size = new System.Drawing.Size(60, 21);
            this.txtNameProducts.TabIndex = 2;
            this.txtNameProducts.Text = "Name:";
            // 
            // txtProductsID
            // 
            this.txtProductsID.Location = new System.Drawing.Point(117, 10);
            this.txtProductsID.Name = "txtProductsID";
            this.txtProductsID.ReadOnly = true;
            this.txtProductsID.Size = new System.Drawing.Size(220, 26);
            this.txtProductsID.TabIndex = 1;
            this.txtProductsID.TextChanged += new System.EventHandler(this.txtProductsID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.btnSearchProducts);
            this.panel4.Location = new System.Drawing.Point(477, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 50);
            this.panel4.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 26);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSearchProducts.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchProducts.Location = new System.Drawing.Point(203, 3);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Size = new System.Drawing.Size(85, 45);
            this.btnSearchProducts.TabIndex = 10;
            this.btnSearchProducts.Text = "Search";
            this.btnSearchProducts.UseVisualStyleBackColor = false;
            this.btnSearchProducts.Click += new System.EventHandler(this.btnSearchProducts_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLoadProducts);
            this.panel3.Controls.Add(this.btnDeleteProduct);
            this.panel3.Controls.Add(this.btnUpdateProdcuts);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 50);
            this.panel3.TabIndex = 1;
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.BackColor = System.Drawing.Color.FloralWhite;
            this.btnLoadProducts.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLoadProducts.Location = new System.Drawing.Point(275, 3);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(85, 45);
            this.btnLoadProducts.TabIndex = 9;
            this.btnLoadProducts.Text = "Load";
            this.btnLoadProducts.UseVisualStyleBackColor = false;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(185, 3);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(85, 45);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProdcuts
            // 
            this.btnUpdateProdcuts.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUpdateProdcuts.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProdcuts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateProdcuts.Location = new System.Drawing.Point(94, 3);
            this.btnUpdateProdcuts.Name = "btnUpdateProdcuts";
            this.btnUpdateProdcuts.Size = new System.Drawing.Size(85, 45);
            this.btnUpdateProdcuts.TabIndex = 7;
            this.btnUpdateProdcuts.Text = "Update";
            this.btnUpdateProdcuts.UseVisualStyleBackColor = false;
            this.btnUpdateProdcuts.Click += new System.EventHandler(this.btnUpdateProdcuts_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddProduct.Location = new System.Drawing.Point(3, 3);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(85, 45);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvProducts);
            this.panel2.Location = new System.Drawing.Point(6, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 323);
            this.panel2.TabIndex = 0;
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToOrderColumns = true;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducts.Location = new System.Drawing.Point(3, 0);
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.RowHeadersWidth = 49;
            this.dtgvProducts.RowTemplate.Height = 28;
            this.dtgvProducts.Size = new System.Drawing.Size(402, 317);
            this.dtgvProducts.TabIndex = 0;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.panel9);
            this.tpAccounts.Controls.Add(this.panel10);
            this.tpAccounts.Controls.Add(this.panel11);
            this.tpAccounts.Location = new System.Drawing.Point(4, 28);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(779, 403);
            this.tpAccounts.TabIndex = 8;
            this.tpAccounts.Text = "Accounts";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.nmTypeAccount);
            this.panel9.Controls.Add(this.btnResetPassword);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.txtDisplayNameAccount);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.txtUserNameAccount);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(418, 95);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 302);
            this.panel9.TabIndex = 2;
            // 
            // nmTypeAccount
            // 
            this.nmTypeAccount.Location = new System.Drawing.Point(145, 140);
            this.nmTypeAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTypeAccount.Name = "nmTypeAccount";
            this.nmTypeAccount.Size = new System.Drawing.Size(89, 26);
            this.nmTypeAccount.TabIndex = 7;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(108, 216);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(126, 42);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(18, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Type:";
            // 
            // txtDisplayNameAccount
            // 
            this.txtDisplayNameAccount.Location = new System.Drawing.Point(145, 90);
            this.txtDisplayNameAccount.Name = "txtDisplayNameAccount";
            this.txtDisplayNameAccount.Size = new System.Drawing.Size(189, 26);
            this.txtDisplayNameAccount.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Display Name:";
            // 
            // txtUserNameAccount
            // 
            this.txtUserNameAccount.Location = new System.Drawing.Point(145, 41);
            this.txtUserNameAccount.Name = "txtUserNameAccount";
            this.txtUserNameAccount.Size = new System.Drawing.Size(189, 26);
            this.txtUserNameAccount.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "User Name:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtgvAccounts);
            this.panel10.Location = new System.Drawing.Point(6, 95);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(380, 302);
            this.panel10.TabIndex = 1;
            // 
            // dtgvAccounts
            // 
            this.dtgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccounts.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccounts.Name = "dtgvAccounts";
            this.dtgvAccounts.RowHeadersWidth = 49;
            this.dtgvAccounts.RowTemplate.Height = 28;
            this.dtgvAccounts.Size = new System.Drawing.Size(374, 296);
            this.dtgvAccounts.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnViewAccount);
            this.panel11.Controls.Add(this.btnDeleteAccount);
            this.panel11.Controls.Add(this.btnUpdateAccount);
            this.panel11.Controls.Add(this.btnAddAccount);
            this.panel11.Location = new System.Drawing.Point(6, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(380, 62);
            this.panel11.TabIndex = 0;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackColor = System.Drawing.Color.FloralWhite;
            this.btnViewAccount.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewAccount.Location = new System.Drawing.Point(276, 14);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(85, 45);
            this.btnViewAccount.TabIndex = 6;
            this.btnViewAccount.Text = "View";
            this.btnViewAccount.UseVisualStyleBackColor = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteAccount.Location = new System.Drawing.Point(185, 14);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(85, 45);
            this.btnDeleteAccount.TabIndex = 5;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateAccount.Location = new System.Drawing.Point(94, 14);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(85, 45);
            this.btnUpdateAccount.TabIndex = 4;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAddAccount.Font = new System.Drawing.Font("Segoe UI Black", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddAccount.Location = new System.Drawing.Point(3, 14);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(85, 45);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tpTable);
            this.Name = "AdminGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGUI";
            this.tpTable.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.tpCategory.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel14.ResumeLayout(false);
            this.tpProduct.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceProducts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.tpAccounts.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccounts)).EndInit();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpTable;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProdcuts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.NumericUpDown nmPriceProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductsName;
        private System.Windows.Forms.Label txtNameProducts;
        private System.Windows.Forms.TextBox txtProductsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDisplayNameAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserNameAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dtgvAccounts;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ComboBox cboCategoryProduct;
        private System.Windows.Forms.NumericUpDown nmTypeAccount;
    }
}