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
    public partial class QueryCustomerControl : UserControl
    {
        public QueryCustomerControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        private string sql = "SELECT cu.CustomerId AS 'Customer ID',"
                            + "cu.Country,"
                            + "r.FirstName AS 'First Name',"
                            + "r.LastName AS 'Last Name',"
                            + "r.StreetAddress,"
                            + "r.Phone,"
                            + "c.CityId,"
                            + "c.CityName,"
                            + "c.State,"
                            + "c.ZipCode"
                            + " FROM Customer cu"
                            + " INNER JOIN Resident r ON cu.CustomerId = r.ResidentId"
                            + " INNER JOIN City c ON c.CityId = r.CityId";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string where = " WHERE ";
            string claus = string.Empty;
            if (!string.IsNullOrEmpty(tCustomerId.Text))
            {
                claus += $" cu.CustomerId={tCustomerId.Text} AND";
            }
            if (!string.IsNullOrEmpty(tFirstName.Text))
            {
                claus += $" r.FirstName='{tFirstName.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tLastName.Text))
            {
                claus += $" r.LastName='{tLastName.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tPhone.Text))
            {
                claus += $" r.Phone='{tPhone.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tCityName.Text))
            {
                claus += $" c.CityName='{tCityName.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tAddress.Text))
            {
                claus += $" r.StreetAddress LIKE '%{tAddress.Text}%'";
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
