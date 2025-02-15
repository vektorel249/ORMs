using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Products;

public partial class FrmNewProduct : Form
{
    public FrmNewProduct()
    {
        InitializeComponent();
    }

    private void FrmNewProduct_Load(object sender, EventArgs e)
    {
        var cRepo = new CategoryRepository();
        cmbCategories.DataSource = cRepo.GetCategoriesAsOptions();
        cmbCategories.DisplayMember = nameof(Option.Name);

        var sRepo = new SupplierRepository();
        cmbSuppliers.DataSource = sRepo.GetSuppliers();
        cmbSuppliers.DisplayMember = nameof(Option.Name);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var repository = new ProductRepository();
        var product = new NewProductDTO
        {
            Name = txtName.Text,
            Price = nudPrice.Value,
            Stock = (int)nudStock.Value,
            CategoryId = int.Parse((cmbCategories.SelectedItem as Option).Code),
            SupplierId = int.Parse((cmbSuppliers.SelectedItem as Option).Code),
        };

        repository.Save(product);
    }
}
