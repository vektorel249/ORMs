namespace Vektorel.Northwind.Erp.Products
{
    partial class FrmCreateCategory
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            erp = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)erp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Açıklama";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 79);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(194, 23);
            txtDescription.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(131, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // erp
            // 
            erp.ContainerControl = this;
            // 
            // FrmCreateCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 164);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "FrmCreateCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Kategori";
            ((System.ComponentModel.ISupportInitialize)erp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
        private Button btnAdd;
        private ErrorProvider erp;
    }
}