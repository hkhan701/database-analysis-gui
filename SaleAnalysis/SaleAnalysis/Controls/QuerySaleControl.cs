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
    public partial class QuerySaleControl : UserControl
    {
        public QuerySaleControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        private string sql = "SELECT s.SaleId AS 'Sale ID',"
                        + "pr.ProductName AS 'Product Name',"
                        + "si.ItemSize AS 'Item Size',"
                        + "si.SalePrice AS 'Sale Price',"
                        + "si.Quantity,"
                        + "s.SaleDate As 'Sale Date',"
                        + "s.Shipping AS 'Shipping',"
                        + "s.Shipping AS 'Shipping Price',"
                        + "c.CustomerId AS 'Customer ID',"
                        + "r.FirstName + ' ' + r.LastName AS 'Customer Name',"
                        + "m.ManufacturerName AS 'Manufacturer Name'"
                        + " FROM Sale s"
                        + " INNER JOIN Customer c ON s.CustomerId = c.CustomerId"
                        + " INNER JOIN Resident r ON c.CustomerId = r.ResidentId"
                        + " INNER JOIN SaleItem si ON s.SaleId = si.SaleId"
                        + " INNER JOIN Product pr ON si.ProductId = pr.ProductId"
                        + " INNER JOIN Manufacturer m ON pr.ManufacturerId = m.ManufacturerId";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string where = " WHERE ";
            string claus = string.Empty;
            if (!string.IsNullOrEmpty(tCustomerId.Text))
            {
                claus += $" c.CustomerId={tCustomerId.Text} AND";
            }
            if (!string.IsNullOrEmpty(tFirstName.Text))
            {
                claus += $" r.FirstName='{tFirstName.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tLastName.Text))
            {
                claus += $" r.LastName='{tLastName.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tManufacturer.Text))
            {
                claus += $" m.ManufacturerName='{tManufacturer.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tProductName.Text))
            {
                claus += $" pr.ProductName='{tProductName.Text}' AND";
            }


            if (!string.IsNullOrEmpty(tStart.Text) && !string.IsNullOrEmpty(tEnd.Text))
            {
                claus += $" s.SaleDate  >= '{tStart.Text}' AND s.SaleDate<='{tEnd.Text}'";
            }else if (!string.IsNullOrWhiteSpace(tStart.Text))
            {
                claus += $" s.SaleDate  >= '{tStart.Text}'";
            }
            else if (!string.IsNullOrWhiteSpace(tEnd.Text))
            {
                claus += $" s.SaleDate<='{tEnd.Text}'";
            }
            else
            {
                if (!string.IsNullOrEmpty(claus))
                    claus = claus.Substring(0, claus.Length - 3);
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
