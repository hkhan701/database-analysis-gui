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
    public partial class StatisticSaleControl : UserControl
    {
        public StatisticSaleControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        private string que = "SELECT s.SaleId AS 'Sale ID',"
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
        private string sql = "SUM(si.SalePrice) AS 'Sale Amount'"
                            + " FROM Sale s"
                        + " INNER JOIN Customer c ON s.CustomerId = c.CustomerId"
                        + " INNER JOIN Resident r ON c.CustomerId = r.ResidentId"
                        + " INNER JOIN SaleItem si ON s.SaleId = si.SaleId"
                        + " INNER JOIN Product pr ON si.ProductId = pr.ProductId"
                        + " INNER JOIN Manufacturer m ON pr.ManufacturerId = m.ManufacturerId";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string select = "SELECT ";
            string group = " GROUP BY ";
            bool groupFlag = false;
            string orderBy = " ORDER BY SUM(si.SalePrice) DESC";
            if (cbYear.Checked)
            {
                select += "YEAR(s.SaleDate) AS 'Year',";
                group += "YEAR(s.SaleDate),";
                groupFlag = true;
            }
            if (cbMonth.Checked)
            {
                select += "MONTH(s.SaleDate) AS 'Month',";
                group += "MONTH(s.SaleDate),";
                groupFlag = true;
            }
            if (cbDay.Checked)
            {
                select += "DAY(s.SaleDate) AS 'Day',";
                group += "DAY(s.SaleDate),";
                groupFlag = true;
            }
            if (cbEmployee.Checked)
            {
                select += "CONCAT(r.FirstName,CONCAT(' ',r.LastName)) AS 'Customer Name',";
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
                claus += $" p.SaleDate  >= '{tStart.Text}' AND p.SaleDate<='{tEnd.Text}'";
            }else if (!string.IsNullOrWhiteSpace(tStart.Text))
            {
                claus += $" p.SaleDate  >= '{tStart.Text}'";
            }
            else if (!string.IsNullOrWhiteSpace(tEnd.Text))
            {
                claus += $" p.SaleDate<='{tEnd.Text}'";
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
