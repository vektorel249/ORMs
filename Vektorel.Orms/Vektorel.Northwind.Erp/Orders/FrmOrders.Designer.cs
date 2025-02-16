namespace Vektorel.Northwind.Erp.Orders
{
    partial class FrmOrders
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
            dgvOrders = new DataGridView();
            btnSearch = new Button();
            txtOrderId = new TextBox();
            label1 = new Label();
            btnDisableFilter = new Button();
            erp = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erp).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 46);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(536, 275);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(367, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(231, 12);
            txtOrderId.MaxLength = 5;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(110, 23);
            txtOrderId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 16);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Sipariş Numarası";
            // 
            // btnDisableFilter
            // 
            btnDisableFilter.Location = new Point(448, 12);
            btnDisableFilter.Name = "btnDisableFilter";
            btnDisableFilter.Size = new Size(100, 23);
            btnDisableFilter.TabIndex = 4;
            btnDisableFilter.Text = "Filtreyi Kaldır";
            btnDisableFilter.UseVisualStyleBackColor = true;
            btnDisableFilter.Click += btnDisableFilter_Click;
            // 
            // erp
            // 
            erp.ContainerControl = this;
            // 
            // FrmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 333);
            Controls.Add(btnDisableFilter);
            Controls.Add(label1);
            Controls.Add(txtOrderId);
            Controls.Add(btnSearch);
            Controls.Add(dgvOrders);
            Name = "FrmOrders";
            Text = "Siparişler";
            Load += FrmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)erp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Button btnSearch;
        private TextBox txtOrderId;
        private Label label1;
        private Button btnDisableFilter;
        private ErrorProvider erp;
    }
}