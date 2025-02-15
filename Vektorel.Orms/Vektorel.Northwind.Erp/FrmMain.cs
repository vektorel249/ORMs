using Vektorel.Northwind.Erp.Helpers;
using Vektorel.Northwind.Erp.Main;
using Vektorel.Northwind.Erp.Products;
using Vektorel.Northwind.Erp.Suppliers;

namespace Vektorel.Northwind.Erp
{
    public partial class FrmMain : Form
    {
        private FormHelper formHelper;
        public FrmMain()
        {
            InitializeComponent();
            formHelper = new FormHelper();
            formHelper.Initialize(this);
        }

        private void msbProducts_Click(object sender, EventArgs e)
        {
            formHelper.OpenForm<FrmProducts>();
        }
        private bool canClose;
        private void msbExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan çýkmak istiyor musunuz?", "Northwind Coo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                canClose = true;
                Application.Exit();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (!canClose)
            {
                msbExit_Click(null, null);
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void msbAbout_Click(object sender, EventArgs e)
        {
            formHelper.OpenForm<FrmAbout>();
        }

        private void msnNewProduct_Click(object sender, EventArgs e)
        {
            formHelper.OpenForm<FrmNewProduct>();
        }

        private void msbNewSupplier_Click(object sender, EventArgs e)
        {
            formHelper.OpenForm<FrmNewSupplier>();
        }

        private void msbNewCategory_Click(object sender, EventArgs e)
        {
            formHelper.OpenForm<FrmCreateCategory>();
        }
    }
}
