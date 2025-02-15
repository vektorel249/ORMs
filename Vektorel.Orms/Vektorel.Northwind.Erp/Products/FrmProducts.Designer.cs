namespace Vektorel.Northwind.Erp.Products
{
    partial class FrmProducts
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
            tabProducts = new TabControl();
            tabPage1 = new TabPage();
            btnPrevious = new Button();
            btnNext = new Button();
            dgvProducts = new DataGridView();
            dgcName = new DataGridViewTextBoxColumn();
            dgcPrice = new DataGridViewTextBoxColumn();
            dgcStock = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            btnNewProduct = new Button();
            btnNewCategory = new Button();
            tabPage3 = new TabPage();
            dgvCategories = new DataGridView();
            dgcCategoryName = new DataGridViewTextBoxColumn();
            dgcCategoryDescription = new DataGridViewTextBoxColumn();
            tabProducts.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(tabPage1);
            tabProducts.Controls.Add(tabPage2);
            tabProducts.Controls.Add(tabPage3);
            tabProducts.Location = new Point(12, 40);
            tabProducts.Name = "tabProducts";
            tabProducts.SelectedIndex = 0;
            tabProducts.Size = new Size(555, 366);
            tabProducts.TabIndex = 1;
            tabProducts.SelectedIndexChanged += tabProducts_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnPrevious);
            tabPage1.Controls.Add(btnNext);
            tabPage1.Controls.Add(dgvProducts);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(547, 338);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tüm Ürünler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(455, 308);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(40, 23);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(501, 308);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { dgcName, dgcPrice, dgcStock });
            dgvProducts.Location = new Point(6, 6);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.Size = new Size(535, 300);
            dgvProducts.TabIndex = 1;
            // 
            // dgcName
            // 
            dgcName.HeaderText = "Ürün Adı";
            dgcName.Name = "dgcName";
            dgcName.ReadOnly = true;
            // 
            // dgcPrice
            // 
            dgcPrice.HeaderText = "Fiyat";
            dgcPrice.Name = "dgcPrice";
            dgcPrice.ReadOnly = true;
            // 
            // dgcStock
            // 
            dgcStock.HeaderText = "Stok Durumu";
            dgcStock.Name = "dgcStock";
            dgcStock.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(547, 338);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ürün Arama";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNewProduct
            // 
            btnNewProduct.Location = new Point(485, 12);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(75, 23);
            btnNewProduct.TabIndex = 2;
            btnNewProduct.Text = "Yeni Ürün";
            btnNewProduct.UseVisualStyleBackColor = true;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // btnNewCategory
            // 
            btnNewCategory.Location = new Point(384, 12);
            btnNewCategory.Name = "btnNewCategory";
            btnNewCategory.Size = new Size(95, 23);
            btnNewCategory.TabIndex = 3;
            btnNewCategory.Text = "Yeni Kategori";
            btnNewCategory.UseVisualStyleBackColor = true;
            btnNewCategory.Click += btnNewCategory_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvCategories);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(547, 338);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kategoriler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { dgcCategoryName, dgcCategoryDescription });
            dgvCategories.Location = new Point(6, 6);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(535, 325);
            dgvCategories.TabIndex = 0;
            // 
            // dgcCategoryName
            // 
            dgcCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgcCategoryName.FillWeight = 121.827408F;
            dgcCategoryName.HeaderText = "Adı";
            dgcCategoryName.Name = "dgcCategoryName";
            dgcCategoryName.ReadOnly = true;
            dgcCategoryName.Width = 120;
            // 
            // dgcCategoryDescription
            // 
            dgcCategoryDescription.FillWeight = 78.17259F;
            dgcCategoryDescription.HeaderText = "Açıklama";
            dgcCategoryDescription.Name = "dgcCategoryDescription";
            dgcCategoryDescription.ReadOnly = true;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 407);
            Controls.Add(btnNewCategory);
            Controls.Add(btnNewProduct);
            Controls.Add(tabProducts);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProducts";
            ShowInTaskbar = false;
            Text = "Ürünler ve Stok Takibi";
            Load += FrmProducts_Load;
            tabProducts.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabProducts;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnNewProduct;
        private Button btnNewCategory;
        private Button btnPrevious;
        private Button btnNext;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn dgcName;
        private DataGridViewTextBoxColumn dgcPrice;
        private DataGridViewTextBoxColumn dgcStock;
        private TabPage tabPage3;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn dgcCategoryName;
        private DataGridViewTextBoxColumn dgcCategoryDescription;
    }
}