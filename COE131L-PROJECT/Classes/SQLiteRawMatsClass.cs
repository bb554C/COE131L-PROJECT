using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace COE131L_PROJECT.Classes
{
    class SQLiteRawMatsClass
    {
        private const string SQLCreateTableDataRawMats
            = "CREATE TABLE DataRawMatsTable"
            + "(DataRawMatsID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL,"
            + "DataMenuItemID INTEGER NOT NULL,"
            + "Date TEXT NOT NULL,"
            + "Price NUMERIC NOT NULL,"
            + "Quantity INTEGER NOT NULL);";
        private const string SQLCreateTableMenuItem
            = "CREATE TABLE MenuItemTable"
            + "(MenuItemID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL,"
            + "MenuItemName TEXT NOT NULL);";
        public static void CreateTable()
        {
            SQLiteConnectionClass.SQLExecuteCommand(SQLCreateTableDataRawMats);
            SQLiteConnectionClass.SQLExecuteCommand(SQLCreateTableMenuItem);
        }
        public static void InsertMenuItem(string TempMenuItemName)
        {
            string SQLInsertExpenseType
            = "INSERT INTO MenuItemTable"
            + " (MenuItemName)"
            + " VALUES ( '" + TempMenuItemName + "' );";
            SQLiteConnectionClass.SQLExecuteCommand(SQLInsertExpenseType);
        }
        public static void InsertDataRawMats(string TempDataRawMatsName, string tempDate, decimal tempPrice, int tempQty)
        {
            string SQLInsertDataRawMats
            = "INSERT INTO DataRawMatsTable"
            + " (DataMenuItemID, Date, Price, Quantity)"
            + " VALUES ( '"
            + GetMenuItemID(TempDataRawMatsName) + "', '"
            + tempDate + "', '"
            + tempPrice + "', '"
            + tempQty
            + "');";
            SQLiteConnectionClass.SQLExecuteCommand(SQLInsertDataRawMats);
        }
        public static int CountMenuItemTable()
        {
            int x = 0;
            string SQLCountExpenseType = "SELECT COUNT(*) MenuItemTable;";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLCountExpenseType;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetInt32(0);
            }
            return x;
        }
        public static int CountRawMatsTable()
        {
            int x = 0;
            string SQLCountExpenseType = "SELECT COUNT(*) DataRawMatsTable;";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLCountExpenseType;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetInt32(0);
            }
            return x;
        }
        private static int GetMenuItemID(string tempName)
        {
            int tempID = 0;
            string SQLSelectExpenseType
            = "SELECT MenuItemID FROM MenuItemTable WHERE MenuItemName = '" + tempName + "';";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLSelectExpenseType;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                tempID = SQLREADER.GetInt32(0);
            }
            return tempID;
        }
        public static List<string> GetMenuItemList()
        {
            List<string> expenseTypeList = new List<string>();
            string SQLSelectExpenseType
            = "SELECT MenuItemName FROM MenuItemTable;";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLSelectExpenseType;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            expenseTypeList.Add("");
            while (SQLREADER.Read())
            {
                expenseTypeList.Add(SQLREADER.GetString(0));
            }
            SQLiteConnectionClass.CloseSQLConnection(SQLConnection);
            return expenseTypeList;
        }
        public static DataSet GetDataRawMats()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter;
            string SQLSelectExpenseType
            = "SELECT DataRawMatsID, Date ,MenuItemName, Price, Quantity "
            + "FROM DataRawMatsTable LEFT JOIN MenuItemTable "
            + "ON DataRawMatsTable.DataMenuItemID = MenuItemTable.MenuItemID;";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLSelectExpenseType;
            adapter = new SQLiteDataAdapter(SQLSelectExpenseType, SQLConnection);
            adapter.Fill(ds);
            SQLiteConnectionClass.CloseSQLConnection(SQLConnection);
            return ds;
        }
    }
}
