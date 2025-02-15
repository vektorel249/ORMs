using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Products
{
    public partial class FrmCreateCategory : Form
    {
        private CategoryRepository repository;
        public FrmCreateCategory()
        {
            InitializeComponent();
            repository = new CategoryRepository();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            erp.Clear();
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                erp.SetError(txtName, "Boş geçilemez"); // validation
                return;
            }

            var category = new NewCategoryDTO
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
            };

            var success = repository.AddCategory(category);

            if (!success)
            {
                MessageBox.Show("Bu kategori zaten eklendi", "Yeni Kategori", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            txtName.Clear();
            txtDescription.Clear();
            Close();
        }
    }
}
