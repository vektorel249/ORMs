using Vektorel.Northwind.Erp.Data.Entities;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Products
{
    public partial class FrmProducts : Form
    {
        private ProductRepository repository;
        public int PageIndex { get; set; }
        public int Total { get; set; }
        public int PageCount { get; set; }

        public FrmProducts()
        {
            InitializeComponent();
            dgvProducts.AutoGenerateColumns = false;
            dgcName.DataPropertyName = nameof(Product.ProductName); // "ProductName" demek
            dgcPrice.DataPropertyName = nameof(Product.UnitPrice); // "UnitPrice" demek
            dgcStock.DataPropertyName = nameof(Product.UnitsInStock); // "UnitsInStock" demek
            repository = new ProductRepository();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = repository.GetProducts(PageIndex);
            Total = repository.GetProductCount();
            PageCount = Total % 10 == 0 ? Total / 10 : (Total / 10) + 1; // if ? true : false
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((PageIndex + 1) >= PageCount)
            {
                return;
            }
            PageIndex++;
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = repository.GetProducts(PageIndex);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (PageIndex > 0)
            {
                PageIndex--;
            }
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = repository.GetProducts(PageIndex);
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var f = new FrmNewProduct();
            f.MdiParent = this.MdiParent;
            f.Show();

            // Ödevde olan tek form açılması konusu geçerli
        }
    }
}
