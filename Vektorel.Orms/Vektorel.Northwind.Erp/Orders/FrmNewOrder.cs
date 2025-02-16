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
using Vektorel.Northwind.Erp.Data.Repositories;
using Vektorel.Orms.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Orders
{
    public partial class FrmNewOrder : Form
    {
        public FrmNewOrder()
        {
            InitializeComponent();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            using var repo = new OrderRepository();
            var order = new NewOrderDTO
            {
                CustomerId = (cmbCustomers.SelectedItem as Option).Code,
                EmployeeId = int.Parse((cmbEmployees.SelectedItem as Option).Code),
                OrderDate = dtpOrderDate.Value,
                RequiredDate = dtpRequiredDate.Value
            };
            var orderId = repo.CreateOrder(order);

            grpDetail.Enabled = true;
            grpDetail.Text = $"Sipariş Numarası : {orderId}";

            using var productRepo = new ProductRepository();

            cmbProducts.DataSource = productRepo.GetProductsAsOptions();
            cmbProducts.DisplayMember = nameof(Option.Name);
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            using var customerRepository = new CustomerRepository();
            using var employeeRepository = new EmployeeRepository();

            cmbCustomers.DataSource = customerRepository.GetCustomersAsOptions(); ;
            cmbCustomers.DisplayMember = nameof(Option.Name);
            cmbEmployees.DataSource = employeeRepository.GetCustomersAsOptions(); ;
            cmbEmployees.DisplayMember = nameof(Option.Name);
        }
    }
}
