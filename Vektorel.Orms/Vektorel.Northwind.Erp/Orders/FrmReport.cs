using ScottPlot;
using ScottPlot.Colormaps;
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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            using var repo = new OrderRepository();
            var performanceData = repo.GetEmployeePerformance();
            var pos = 0;
            var ticks = new Tick[performanceData.Count];
            foreach (var data in performanceData)
            {
                ticks[pos] = new Tick(++pos, data.Employee);
                reportChart.Plot.Add.Bar(position: pos, value: (double)data.Total);
            }

            reportChart.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            reportChart.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            reportChart.Plot.Axes.Bottom.TickLabelStyle.Rotation = -45;
            reportChart.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;
            reportChart.Plot.HideGrid();
            reportChart.Plot.Axes.Margins(bottom: 0);

            reportChart.Refresh();
        }
    }
}
