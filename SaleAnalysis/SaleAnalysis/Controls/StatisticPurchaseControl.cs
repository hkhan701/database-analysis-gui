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
    public partial class StatisticPurchaseControl : UserControl
    {
        public StatisticPurchaseControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        private string que = "SELECT p.PurchaseId AS 'Purchase ID',"
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
        private string sql = "SUM(pit.PurchasePrice) AS 'Purchase Amount'"
                            + " FROM Purchase p"
                            + " INNER JOIN Employee e ON p.EmployeeId = e.EmployeeId"
                            + " INNER JOIN Resident r ON e.EmployeeId = r.ResidentId"
                            + " INNER JOIN PurchaseItem pit ON p.PurchaseId = pit.PurchaseId"
                            + " INNER JOIN Product pr ON pit.ProductId = pr.ProductId"
                            + " INNER JOIN Manufacturer m ON pr.ManufacturerId = m.ManufacturerId";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string select = "SELECT ";
            string group = " GROUP BY ";
            bool groupFlag = false;
            string orderBy = " ORDER BY SUM(pit.PurchasePrice) DESC";
            if (cbYear.Checked)
            {
                select += "YEAR(p.PurchaseDate) AS 'Year',";
                group += "YEAR(p.PurchaseDate),";
                groupFlag = true;
            }
            if (cbMonth.Checked)
            {
                select += "MONTH(p.PurchaseDate) AS 'Month',";
                group += "MONTH(p.PurchaseDate),";
                groupFlag = true;
            }
            if (cbDay.Checked)
            {
                select += "DAY(p.PurchaseDate) AS 'Day',";
                group += "DAY(p.PurchaseDate),";
                groupFlag = true;
            }
            if (cbEmployee.Checked)
            {
                select += "CONCAT(r.FirstName,CONCAT(' ',r.LastName)) AS 'Employee Name',";
                group += "CONCAT(r.FirstName,CONCAT(' ',r.LastName)),";
                groupFlag = true;
            }
            if (cbProduct.Checked)
            {
                select += "pr.ProductName AS 'Product Name',";
                group += "pr.ProductName,";
                groupFlag = true;
            }
            if (cbManufacturer.Checked)
            {
                select += "m.ManufacturerName AS 'Manufacturer Name',";
                group += "m.ManufacturerName";
                groupFlag = true;
            }
            if (!groupFlag)
            {
                MessageBox.Show("Please check at least on group condition.");
                return;
            }

            group = group.Trim(',');

            string where = " WHERE ";
            string claus = string.Empty;
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
                tmp = select + sql + where + claus + group + orderBy;
            }
            else
            {
                tmp = select + sql + group + orderBy;
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
