using SaleAnalysis.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleAnalysis
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonProductInfo_Click(object sender, EventArgs e)
        {
            var control = new QueryProductControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonEmployeeInfo_Click(object sender, EventArgs e)
        {
            var control = new QueryEmployeeControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonCustomerInfo_Click(object sender, EventArgs e)
        {
            var control = new QueryCustomerControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonInventoryInfo_Click(object sender, EventArgs e)
        {
            var control = new QueryInventoryControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonPurchaseInfo_Click(object sender, EventArgs e)
        {
            var control = new QueryPurchaseControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonSaleInfo_Click(object sender, EventArgs e)
        {
            var control = new QuerySaleControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonStatisticPurchase_Click(object sender, EventArgs e)
        {
            var control = new StatisticPurchaseControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void buttonStatisticSale_Click(object sender, EventArgs e)
        {
            var control = new StatisticSaleControl();
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }
    }
}
