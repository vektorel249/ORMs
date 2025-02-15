using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Products
{
    public partial class FrmUpdateCategory : Form
    {
        private CategoryRepository repository;
        private int categoryId;
        public FrmUpdateCategory()
        {
            InitializeComponent();
            repository = new CategoryRepository();
        }

        public void SetValues(CategoryDTO category)
        {
            txtName.Text = category.Name;
            txtDescription.Text = category.Description;
            categoryId = category.Id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            erp.Clear();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                erp.SetError(txtName, "Boş geçilemez"); // validation
                return;
            }
            var category = new CategoryDTO
            {
                Id = categoryId,
                Name = txtName.Text,
                Description = txtDescription.Text,
            };
            var success = repository.Update(category);

            if (!success)
            {
                MessageBox.Show("Bu kategori zaten var", "Kategori Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtName.Clear();
            txtDescription.Clear();
            Close();
        }
    }
}
