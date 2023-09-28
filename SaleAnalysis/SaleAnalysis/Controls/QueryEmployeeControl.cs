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
    public partial class QueryEmployeeControl : UserControl
    {
        public QueryEmployeeControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        private string sql = "SELECT e.EmployeeId AS 'Employee ID',"
                            + "r.FirstName AS 'First Name',"
                            + "r.LastName AS 'Last Name',"
                            + "e.HireDate AS 'Hire Date',"
                            + "e.ManagerId AS 'Manager ID',"
                            + "e.SSN,"
                            + "e.EmailAddress AS 'Email',"
                            + "e.Salary,"
                            + "r.StreetAddress AS 'Address',"
                            + "r.Phone,"
                            // + "c.CityId AS 'City ID',"
                            + "c.CityName AS 'City Name',"
                            + "c.State,"
                            + "c.ZipCode AS 'ZIP'"
                            + " FROM Employee e"
                            + " INNER JOIN Resident r ON e.EmployeeId = r.ResidentId"
                            + " INNER JOIN City c ON c.CityId = r.CityId";
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
            if (!string.IsNullOrEmpty(tSSN.Text))
            {
                claus += $" e.SSN='{tSSN.Text}' AND";
            }
            if (!string.IsNullOrEmpty(tManageId.Text))
            {
                claus += $" e.ManagerId={tManageId.Text} AND";
            }
            if (!string.IsNullOrEmpty(tEmail.Text))
            {
                claus += $" e.EmailAddress='{tEmail.Text}' AND";
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
