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
    public partial class FrmOrderDetail : Form
    {
        
        public FrmOrderDetail()
        {
            InitializeComponent();
        }

        public void LoadOrder(int orderId)
        {
            #region Sipariş Üst Verisi
            using var orderRepository = new OrderRepository();
            var order = orderRepository.GetMetadata(orderId);

            lblCustomer.Text = order.Customer;
            lblPhone.Text = order.Phone;
            lblEmployee.Text = order.Employee;
            lblOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy HH:mm"); // saatli date
            lblRequiredDate.Text = order.RequiredDate.ToString("dd/MM/yyyy"); // saatsiz date 
            #endregion

            #region Detay Bilgisi
            var details = orderRepository.GetDetails(orderId);
            var total = 0M;
            foreach (var detail in details)
            {
                var item = new ListViewItem(detail.Product);
                item.SubItems.Add(detail.Price.ToString());
                item.SubItems.Add(detail.Amount.ToString());
                lstDetails.Items.Add(item);

                total += detail.Price * detail.Amount;
            }

            lblTotal.Text = $"{total.ToString("0.00")} TL";
            #endregion
        }
    }
}
