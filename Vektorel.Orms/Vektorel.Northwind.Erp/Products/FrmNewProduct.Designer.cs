namespace Vektorel.Northwind.Erp.Products
{
    partial class FrmNewProduct
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
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            label4 = new Label();
            cmbCategories = new ComboBox();
            cmbSuppliers = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(182, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Fiyat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Stok";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 23);
            txtName.TabIndex = 4;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(13, 80);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 5, 0, 0, 131072 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(245, 23);
            nudPrice.TabIndex = 5;
            nudPrice.Value = new decimal(new int[] { 5, 0, 0, 131072 });
            // 
            // nudStock
            // 
            nudStock.Location = new Point(12, 124);
            nudStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(245, 23);
            nudStock.TabIndex = 6;
            nudStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 150);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Ürün Türü";
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(13, 168);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(245, 23);
            cmbCategories.TabIndex = 8;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(12, 212);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(245, 23);
            cmbSuppliers.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 194);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 10;
            label5.Text = "Tedarikçi";
            // 
            // FrmNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 303);
            Controls.Add(label5);
            Controls.Add(cmbSuppliers);
            Controls.Add(cmbCategories);
            Controls.Add(label4);
            Controls.Add(nudStock);
            Controls.Add(nudPrice);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "FrmNewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Ürün Tanımı";
            Load += FrmNewProduct_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private Label label4;
        private ComboBox cmbCategories;
        private ComboBox cmbSuppliers;
        private Label label5;
    }
}