using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Entities;
using Vektorel.Northwind.Erp.Helpers;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Products
{
    public partial class FrmProducts : Form
    {
        private ProductRepository repository;
        private CategoryRepository categoryRepository;
        private FormHelper formHelper;
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

            dgvCategories.AutoGenerateColumns = false; // Modelde başka property ler varsa datagridview'e ekleme!
            dgcCategoryName.DataPropertyName = nameof(CategoryDTO.Name);
            dgcCategoryDescription.DataPropertyName = nameof(CategoryDTO.Description);

            repository = new ProductRepository();
            categoryRepository = new CategoryRepository();
            formHelper = new FormHelper();
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
            formHelper.OpenForm<FrmNewProduct>();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            formHelper.OpenForm<FrmCreateCategory>();
        }

        private void tabProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabProducts.SelectedIndex == 2) // Kategori sekmesi
            {
                dgvCategories.DataSource = null;
                dgvCategories.DataSource = categoryRepository.GetCategories();
            }
        }

        private void dgvCategories_KeyDown(object sender, KeyEventArgs e)
        {
            // Delete tuşuna basılırsa kategoriyi sil
        }
    }
}
