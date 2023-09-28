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
    public partial class QueryPurchaseControl : UserControl
    {
        public QueryPurchaseControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        private string sql = "SELECT p.PurchaseId AS 'Purchase ID',"
                            + "pr.ProductName AS 'Product Name',"
                            + "pit.ItemSize AS 'Item Size',"
                            + "pit.PurchasePrice AS 'Purchase Price',"
                            + "pit.Quantity,"
                            + "p.PurchaseDate As 'Purchase Date',"
                            + "P.ExpectedDeliveryDate AS 'Expected Delivery Date',"
                            + "p.Shipping AS 'Shipping Price',"
                            + "e.EmployeeId AS 'Employee ID',"
                            + "r.FirstName + ' ' + r.LastName AS 'Employee Name',"
                            + "m.ManufacturerName AS 'Manufacturer Name'"
                            + " FROM Purchase p"
                            + " INNER JOIN Employee e ON p.EmployeeId = e.EmployeeId"
                            + " INNER JOIN Resident r ON e.EmployeeId = r.ResidentId"
                            + " INNER JOIN PurchaseItem pit ON p.PurchaseId = pit.PurchaseId"
                            + " INNER JOIN Product pr ON pit.ProductId = pr.ProductId"
                            + " INNER JOIN Manufacturer m ON pr.ManufacturerId = m.ManufacturerId";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string where = " WHERE ";
            string claus = string.Empty;
            if (!string.IsNullOrEmpty(tEmployeeId.Text))
            {
                claus += $" e.EmployeeId={tEmployeeId.Text} AND";
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
                claus += $" p.PurchaseDate  >= '{tStart.Text}' AND p.PurchaseDate<='{tEnd.Text}'";
            }else if (!string.IsNullOrWhiteSpace(tStart.Text))
            {
                claus += $" p.PurchaseDate  >= '{tStart.Text}'";
            }
            else if (!string.IsNullOrWhiteSpace(tEnd.Text))
            {
                claus += $" p.PurchaseDate<='{tEnd.Text}'";
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
