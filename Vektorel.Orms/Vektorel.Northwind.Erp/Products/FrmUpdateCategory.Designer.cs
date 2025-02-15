namespace Vektorel.Northwind.Erp.Products
{
    partial class FrmUpdateCategory
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
            components = new System.ComponentModel.Container();
            btnUpdate = new Button();
            txtDescription = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            erp = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)erp).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(136, 124);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Kaydet";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(17, 83);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 23);
            txtDescription.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Açıklama";
            // 
            // txtName
            // 
            txtName.Location = new Point(17, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 23);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Kategori Adı";
            // 
            // erp
            // 
            erp.ContainerControl = this;
            // 
            // FrmUpdateCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 161);
            Controls.Add(btnUpdate);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "FrmUpdateCategory";
            Text = "Kategori Güncelle";
            ((System.ComponentModel.ISupportInitialize)erp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private ErrorProvider erp;
    }
}