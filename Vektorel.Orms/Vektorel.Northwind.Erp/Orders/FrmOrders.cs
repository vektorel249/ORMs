using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Northwind.Erp.Data.Repositories;

namespace Vektorel.Northwind.Erp.Orders
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
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
    }
}
