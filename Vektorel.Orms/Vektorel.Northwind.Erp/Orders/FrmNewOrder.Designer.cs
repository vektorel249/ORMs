namespace Vektorel.Northwind.Erp.Orders
{
    partial class FrmNewOrder
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
            btnCreateOrder = new Button();
            cmbCustomers = new ComboBox();
            cmbEmployees = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            grpDetail = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            cmbProducts = new ComboBox();
            dgvDetail = new DataGridView();
            grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(63, 211);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(100, 23);
            btnCreateOrder.TabIndex = 0;
            btnCreateOrder.Text = "Sipariş Oluştur";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // cmbCustomers
            // 
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(10, 29);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(153, 23);
            cmbCustomers.TabIndex = 1;
            // 
            // cmbEmployees
            // 
            cmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(10, 77);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(153, 23);
            cmbEmployees.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Müşteri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Satış Danışmanı";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpOrderDate.Format = DateTimePickerFormat.Custom;
            dtpOrderDate.Location = new Point(10, 125);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(153, 23);
            dtpOrderDate.TabIndex = 5;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.CustomFormat = "dd/MM/yyyy";
            dtpRequiredDate.Format = DateTimePickerFormat.Custom;
            dtpRequiredDate.Location = new Point(10, 173);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(153, 23);
            dtpRequiredDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 103);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Sipariş Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 151);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "Teslim Tarihi";
            // 
            // grpDetail
            // 
            grpDetail.Controls.Add(label7);
            grpDetail.Controls.Add(label6);
            grpDetail.Controls.Add(label5);
            grpDetail.Controls.Add(numericUpDown2);
            grpDetail.Controls.Add(numericUpDown1);
            grpDetail.Controls.Add(cmbProducts);
            grpDetail.Controls.Add(dgvDetail);
            grpDetail.Enabled = false;
            grpDetail.Location = new Point(169, 12);
            grpDetail.Name = "grpDetail";
            grpDetail.Size = new Size(457, 240);
            grpDetail.TabIndex = 9;
            grpDetail.TabStop = false;
            grpDetail.Text = "Sipariş Henüz Oluşturulmadı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(331, 25);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 14;
            label7.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 25);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 13;
            label6.Text = "Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Ürün";
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(331, 44);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 12;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(205, 43);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(6, 43);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(193, 23);
            cmbProducts.TabIndex = 10;
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(6, 75);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.Size = new Size(445, 147);
            dgvDetail.TabIndex = 0;
            // 
            // FrmNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 264);
            Controls.Add(grpDetail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEmployees);
            Controls.Add(cmbCustomers);
            Controls.Add(btnCreateOrder);
            Name = "FrmNewOrder";
            Text = "Yeni Sipariş";
            Load += FrmNewOrder_Load;
            grpDetail.ResumeLayout(false);
            grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateOrder;
        private ComboBox cmbCustomers;
        private ComboBox cmbEmployees;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private Label label3;
        private Label label4;
        private GroupBox grpDetail;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ComboBox cmbProducts;
        private DataGridView dgvDetail;
    }
}