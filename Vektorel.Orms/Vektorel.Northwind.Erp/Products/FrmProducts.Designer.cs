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
            tabControl1 = new TabControl();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 40);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(555, 366);
            tabControl1.TabIndex = 1;
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
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 407);
            Controls.Add(btnNewCategory);
            Controls.Add(btnNewProduct);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProducts";
            ShowInTaskbar = false;
            Text = "Ürünler ve Stok Takibi";
            Load += FrmProducts_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
    }
}