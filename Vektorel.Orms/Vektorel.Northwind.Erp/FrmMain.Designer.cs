namespace Vektorel.Northwind.Erp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            uygulamaToolStripMenuItem = new ToolStripMenuItem();
            msbAbout = new ToolStripMenuItem();
            msbExit = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            msnNewProduct = new ToolStripMenuItem();
            msbProducts = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            msbSuppliersTopMenu = new ToolStripMenuItem();
            msbNewSupplier = new ToolStripMenuItem();
            msbSuppliers = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            msbNewCategory = new ToolStripMenuItem();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            msbNewCustomer = new ToolStripMenuItem();
            msbCustomers = new ToolStripMenuItem();
            msbOrders = new ToolStripMenuItem();
            msbSearchOrder = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uygulamaToolStripMenuItem, ürünYönetimiToolStripMenuItem, siparişYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(557, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            uygulamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { msbAbout, msbExit });
            uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            uygulamaToolStripMenuItem.Size = new Size(73, 20);
            uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // msbAbout
            // 
            msbAbout.Name = "msbAbout";
            msbAbout.Size = new Size(124, 22);
            msbAbout.Text = "Hakkında";
            msbAbout.Click += msbAbout_Click;
            // 
            // msbExit
            // 
            msbExit.Name = "msbExit";
            msbExit.Size = new Size(124, 22);
            msbExit.Text = "Çıkış";
            msbExit.Click += msbExit_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { msnNewProduct, msbProducts, toolStripSeparator1, msbSuppliersTopMenu, toolStripSeparator2, msbNewCategory });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(95, 20);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // msnNewProduct
            // 
            msnNewProduct.Name = "msnNewProduct";
            msnNewProduct.Size = new Size(143, 22);
            msnNewProduct.Text = "Yeni Ürün";
            msnNewProduct.Click += msnNewProduct_Click;
            // 
            // msbProducts
            // 
            msbProducts.Name = "msbProducts";
            msbProducts.Size = new Size(143, 22);
            msbProducts.Text = "Ürünler";
            msbProducts.Click += msbProducts_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(140, 6);
            // 
            // msbSuppliersTopMenu
            // 
            msbSuppliersTopMenu.DropDownItems.AddRange(new ToolStripItem[] { msbNewSupplier, msbSuppliers });
            msbSuppliersTopMenu.Name = "msbSuppliersTopMenu";
            msbSuppliersTopMenu.Size = new Size(143, 22);
            msbSuppliersTopMenu.Text = "Tedarikçiler";
            // 
            // msbNewSupplier
            // 
            msbNewSupplier.Name = "msbNewSupplier";
            msbNewSupplier.Size = new Size(145, 22);
            msbNewSupplier.Text = "Yeni Tedarikçi";
            msbNewSupplier.Click += msbNewSupplier_Click;
            // 
            // msbSuppliers
            // 
            msbSuppliers.Name = "msbSuppliers";
            msbSuppliers.Size = new Size(145, 22);
            msbSuppliers.Text = "Tedarikçiler";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(140, 6);
            // 
            // msbNewCategory
            // 
            msbNewCategory.Name = "msbNewCategory";
            msbNewCategory.Size = new Size(143, 22);
            msbNewCategory.Text = "Yeni Kategori";
            msbNewCategory.Click += msbNewCategory_Click;
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { msbNewCustomer, msbCustomers, msbOrders, msbSearchOrder });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(103, 20);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // msbNewCustomer
            // 
            msbNewCustomer.Name = "msbNewCustomer";
            msbNewCustomer.Size = new Size(180, 22);
            msbNewCustomer.Text = "Yeni Müşteri";
            // 
            // msbCustomers
            // 
            msbCustomers.Name = "msbCustomers";
            msbCustomers.Size = new Size(180, 22);
            msbCustomers.Text = "Müşteriler";
            // 
            // msbOrders
            // 
            msbOrders.Name = "msbOrders";
            msbOrders.Size = new Size(180, 22);
            msbOrders.Text = "Siparişler";
            msbOrders.Click += msbOrders_Click;
            // 
            // msbSearchOrder
            // 
            msbSearchOrder.Name = "msbSearchOrder";
            msbSearchOrder.Size = new Size(180, 22);
            msbSearchOrder.Text = "Sipariş Arama";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 381);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Northwin Coo.";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uygulamaToolStripMenuItem;
        private ToolStripMenuItem msbAbout;
        private ToolStripMenuItem msbExit;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem msnNewProduct;
        private ToolStripMenuItem msbProducts;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem msbSuppliersTopMenu;
        private ToolStripMenuItem msbNewSupplier;
        private ToolStripMenuItem msbSuppliers;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem msbNewCategory;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem msbNewCustomer;
        private ToolStripMenuItem msbCustomers;
        private ToolStripMenuItem msbOrders;
        private ToolStripMenuItem msbSearchOrder;
    }
}
