using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleAnalysis
{
    public class QueryService
    {
        public QueryService()
        {
            con = ConfigurationManager.AppSettings.Get("SaleManagement");
        }
        private string con;

        public DataTable Query(string sql)
        {
            using(var c = new SqlConnection(con))
            {
                c.Open();
                var command = new SqlCommand(sql, c);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
