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
    class SQLitePriceListClass
    {
        public static decimal computeSuggestedPrice(decimal aveRawPrice, float SumPortion, float sumAll, decimal sumAllExpenses, float markup)
        {
            decimal x;
            decimal addToBreakeven = (((decimal)SumPortion / (decimal) sumAll) * sumAllExpenses)/ (decimal)SumPortion;
            decimal addProfit = aveRawPrice * ((decimal) markup/100);
            x = aveRawPrice + addToBreakeven + addProfit; 
            return x;
        }
        public static DataSet getData(float percent)
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("Item Name");
            table.Columns.Add("Suggested Price");
            for (int x = 0; x < SQLiteRawMatsClass.CountMenuItemTable(); x++)
            {
                int i = x + 1;
                table.Rows.Add(SQLiteRawMatsClass.GetMenuItemName(i), computeSuggestedPrice(getAvePrice(i), getSumSalesQuantity(i),getSumAllQuantity(),getSumExpenses(),percent).ToString("0.00"));
            }
            ds.Tables.Add(table);
            return ds;
        }
        public static decimal getAvePrice(int tempID)
        {
            decimal x = 0;
            string SQLCountExpenseType = "SELECT avg(Price) FROM DataRawMatsTable WHERE DataMenuItemID = '" + tempID + "';";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLCountExpenseType;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetDecimal(0);
            }
            return x;
        }
        public static float getSumSalesQuantity(int tempID)
        {
            float x = 0;
            string SQLPORTION = "SELECT SUM(SaleQuantity) FROM SalesTable WHERE MenuItemID = '" + tempID + "';";
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLiteCommand SQLCMD;
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLPORTION;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetFloat(0);
            }
            return x;
        }
        public static float getSumAllQuantity()
        {
            float x = 0;
            string SQLSUM = "SELECT SUM(SaleQuantity) FROM SalesTable;";
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLiteCommand SQLCMD;
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLSUM;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetFloat(0);
            }
            return x;
        }

        public static decimal getSumExpenses()
        {
            decimal x = 0;
            string SQLSUM = "SELECT SUM(Price) FROM DataExpenseTable;";
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLiteCommand SQLCMD;
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLSUM;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetDecimal(0);
            }
            return x;
        }
    }
}
