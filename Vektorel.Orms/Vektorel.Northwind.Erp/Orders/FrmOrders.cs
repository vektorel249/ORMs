using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Repositories;
using Vektorel.Northwind.Erp.Helpers;

namespace Vektorel.Northwind.Erp.Orders
{
    public partial class FrmOrders : Form
    {
        private FormHelper formHelper;

        public FrmOrders()
        {
            InitializeComponent();
            formHelper = new FormHelper();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            btnDisableFilter.Enabled = false;
            using var repo = new OrderRepository();
            dgvOrders.DataSource = repo.GetLastOrders();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            erp.Clear();
            if (!int.TryParse(txtOrderId.Text, out var orderId))
            {
                erp.SetError(txtOrderId, "Sipariş numarası 5 haneli sayı olmalı");
                return;
            }
            using var repo = new OrderRepository();
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = repo.GetLastOrders(orderId);
            btnDisableFilter.Enabled = true;
        }

        private void btnDisableFilter_Click(object sender, EventArgs e)
        {
            FrmOrders_Load(null, null);
            txtOrderId.Clear();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                return;
            }
            var selected = dgvOrders.SelectedRows[0].DataBoundItem as OrderListDTO;

            var f = formHelper.OpenForm<FrmOrderDetail>();
            f.LoadOrder(selected.OrderId);
        }
    }
}
