namespace Vektorel.Northwind.Erp.Orders
{
    partial class FrmOrderDetail
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
            lblCustomer = new Label();
            lstDetails = new ListView();
            lvcProduct = new ColumnHeader();
            lvcPrice = new ColumnHeader();
            lvcAmount = new ColumnHeader();
            lblRequiredDate = new Label();
            lblEmployee = new Label();
            lblOrderDate = new Label();
            lblTotal = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCustomer.Location = new Point(12, 12);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(107, 25);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Adı Soyadı";
            // 
            // lstDetails
            // 
            lstDetails.Columns.AddRange(new ColumnHeader[] { lvcProduct, lvcPrice, lvcAmount });
            lstDetails.FullRowSelect = true;
            lstDetails.Location = new Point(12, 97);
            lstDetails.Name = "lstDetails";
            lstDetails.Size = new Size(441, 237);
            lstDetails.TabIndex = 1;
            lstDetails.UseCompatibleStateImageBehavior = false;
            lstDetails.View = View.Details;
            // 
            // lvcProduct
            // 
            lvcProduct.Text = "Ürün";
            lvcProduct.Width = 150;
            // 
            // lvcPrice
            // 
            lvcPrice.Text = "Fiyat";
            // 
            // lvcAmount
            // 
            lvcAmount.Text = "Miktar";
            // 
            // lblRequiredDate
            // 
            lblRequiredDate.Location = new Point(288, 45);
            lblRequiredDate.Name = "lblRequiredDate";
            lblRequiredDate.Size = new Size(165, 15);
            lblRequiredDate.TabIndex = 2;
            lblRequiredDate.Text = "20/02/2025";
            lblRequiredDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmployee
            // 
            lblEmployee.Location = new Point(288, 70);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(165, 15);
            lblEmployee.TabIndex = 3;
            lblEmployee.Text = "Nancy Davolio";
            lblEmployee.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Location = new Point(288, 20);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(165, 15);
            lblOrderDate.TabIndex = 4;
            lblOrderDate.Text = "01/01/2025 14:45:32";
            lblOrderDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 70);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "1200,00 TL";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(12, 45);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(96, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "+90 312 312 1212";
            // 
            // FrmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 346);
            Controls.Add(lblPhone);
            Controls.Add(lblTotal);
            Controls.Add(lblOrderDate);
            Controls.Add(lblEmployee);
            Controls.Add(lblRequiredDate);
            Controls.Add(lstDetails);
            Controls.Add(lblCustomer);
            Name = "FrmOrderDetail";
            Text = "Sipariş Detayı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private ListView lstDetails;
        private Label lblRequiredDate;
        private Label lblEmployee;
        private Label lblOrderDate;
        private Label lblTotal;
        private Label lblPhone;
        private ColumnHeader lvcProduct;
        private ColumnHeader lvcPrice;
        private ColumnHeader lvcAmount;
    }
}