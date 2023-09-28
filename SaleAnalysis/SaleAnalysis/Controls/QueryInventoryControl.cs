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
    public partial class QueryInventoryControl : UserControl
    {
        public QueryInventoryControl()
        {
            InitializeComponent();
            service = new QueryService();
        }
        private QueryService service;
        string sql = "SELECT p.ProductId AS 'Product ID',"
                    + "p.ProductName AS 'Product Name',"
                    + "i.ItemSize AS 'Item Size',"
                    + "i.QtyOnHand AS 'QTY On Hand'"
                    + " FROM Product p"
                    + " INNER JOIN InventoryItem i ON p.ProductId = i.ProductId";
        

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
            if (!string.IsNullOrEmpty(tSize.Text))
            {
                claus += $" i.ItemSize={tSize.Text}";
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
