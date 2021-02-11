using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COE131L_PROJECT.Classes;

namespace COE131L_PROJECT.Classes
{
    class SQLiteShoppingClass
    {
        public static DataSet getData()
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("Item Name");
            table.Columns.Add("Suggested Quantity");
            for (int x = 0; x < SQLiteRawMatsClass.CountMenuItemTable(); x++)
            {
                int i = x + 1;
                table.Rows.Add(SQLiteRawMatsClass.GetMenuItemName(i),getAveQty(i).ToString("0.00"));
            }
            ds.Tables.Add(table);
            return ds;
        }
        public static float getAveQty(int tempID)
        {
            float x = 0;
            string SQLCountExpenseType = "SELECT avg(SaleQuantity) FROM SalesTable WHERE MenuItemID = '"+ tempID + "';";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLCountExpenseType;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetFloat(0);
            }
            return x;
        }
    }
}
