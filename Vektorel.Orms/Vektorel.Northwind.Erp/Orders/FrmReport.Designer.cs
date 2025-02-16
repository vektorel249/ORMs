namespace Vektorel.Northwind.Erp.Orders
{
    partial class FrmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportChart = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // reportChart
            // 
            reportChart.DisplayScale = 1F;
            reportChart.Location = new Point(12, 12);
            reportChart.Name = "reportChart";
            reportChart.Padding = new Padding(0, 0, 0, 50);
            reportChart.Size = new Size(508, 452);
            reportChart.TabIndex = 0;
            // 
            // FrmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 476);
            Controls.Add(reportChart);
            Name = "FrmReport";
            Text = "Personel Satış Karşılaştırması";
            Load += FrmReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot reportChart;
    }
}