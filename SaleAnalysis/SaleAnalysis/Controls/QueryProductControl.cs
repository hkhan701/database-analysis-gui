using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleAnalysis.Controls
{
    public partial class QueryProductControl : UserControl
    {
        public QueryProductControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        string sql = "SELECT p.ProductId AS 'Product Id',"
                     + "p.ProductName AS 'Prodcut Name',"
                     + "p.Composition,"
                     + "p.ListPrice AS 'List Price',"
                     + "p.Gender,"
                     + "p.Category,"
                     + "p.Color,"
                     + "p.Description,"
                     + "m.ManufacturerId AS 'Manufacturer Id',"
                     + "m.ManufacturerName AS 'Manufacturer Name'"
                     + " FROM Product p"
                     + " INNER JOIN Manufacturer m ON p.ManufacturerId = m.ManufacturerId";
        

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string where = " WHERE ";
            string claus = string.Empty;
            if (!string.IsNullOrEmpty(tProductId.Text))
            {
                claus += $" p.ProductId='{tProductId.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tProductName.Text))
            {
                claus += $" p.ProductName='{tProductName.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tManufacturerId.Text))
            {
                claus += $" m.ManufacturerId='{tManufacturerId.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tManufacturerName.Text))
            {
                claus += $" m.ManufacturerName='{tManufacturerName.Text}' AND";
            }

            if (!string.IsNullOrEmpty(tCategory.Text))
            {
                claus += $" p.Category='{tCategory.Text}' AND";
            }

            if (!string.IsNullOrEmpty(tDescription.Text))
            {
                claus += $" p.Description LIKE '%{tDescription.Text}%'";
            }
            else
            {
                if(!string.IsNullOrEmpty(claus))
                    claus = claus.Substring(0,claus.Length - 3);
            }

            string tmp;
            if (!string.IsNullOrEmpty(claus))
            {
                tmp = sql + where + claus;
            }
            else
            {
                tmp = sql;
            }
            var table = service.Query(tmp);
            grid.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("There are no datas with the query condition.");
            }
        }
    }
}
