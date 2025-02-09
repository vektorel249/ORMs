using Vektorel.Northwind.Erp.Main;
using Vektorel.Northwind.Erp.Products;
using Vektorel.Northwind.Erp.Suppliers;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void msbProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmProducts>();
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
            OpenChildForm<FrmAbout>();
        }

        private void msnNewProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmNewProduct>();
        }

        private void msbNewSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmNewSupplier>();
        }

        private void msbNewCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmCreateCategory>();
        }

        private void OpenChildForm<F>() where F : Form
        {
            var f = Activator.CreateInstance<F>(); // method ile instance alma yöntemi (Reflection)
            //var f = new F(); ama bunu yazamayýz. Bkz. Generic konusu
            f.MdiParent = this; // FRMMain içinde açýlmasý için
            f.Show();

            // Her formu yalnýzca bir kere açabilecek bir þey yapýn.
            // Ýpucu: Araþtýrýnýz => Dictionary
        }
    }
}
