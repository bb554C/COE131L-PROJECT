using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace COE131L_PROJECT.Classes
{
    class SQLiteExpensesClass
    {
        private const string SQLCreateTableDataExpense 
            = "CREATE TABLE DataExpenseTable"
            + "(DataExpenseID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL,"
            + "DataExpenseTypeID INTEGER NOT NULL,"
            + "Date TEXT NOT NULL,"
            + "Price NUMERIC NOT NULL,"
            + "Quantity INTEGER NOT NULL);";
        private const string SQLCreateTableExpenseType 
            = "CREATE TABLE ExpenseTypeTable"
            + "(ExpenseTypeID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL,"
            + "ExpenseTypeName TEXT NOT NULL);";
        public static void CreateTable()
        {
            SQLiteConnectionClass.SQLExecuteCommand(SQLCreateTableDataExpense);
            SQLiteConnectionClass.SQLExecuteCommand(SQLCreateTableExpenseType);
        }
        public static void InsertExpenseType(string TempExpenseTypeName)
        {
            string SQLInsertExpenseType
            = "INSERT INTO ExpenseTypeTable"
            + " (ExpenseTypeName)"
            + " VALUES ( '" + TempExpenseTypeName + "' );";
            SQLiteConnectionClass.SQLExecuteCommand(SQLInsertExpenseType);
        }
        public static void InsertDataExpense(string TempExpenseTypeName, string tempDate, decimal tempPrice, int tempQty )
        {
            string SQLInsertExpenseType
            = "INSERT INTO DataExpenseTable"
            + " (DataExpenseTypeID, Date, Price, Quantity)"
            + " VALUES ( '" 
            + GetExpenseTypeID(TempExpenseTypeName) + "', '"
            + tempDate + "', '"
            + tempPrice + "', '"
            + tempQty
            + "');";
            SQLiteConnectionClass.SQLExecuteCommand(SQLInsertExpenseType);
        }
        public static int CountExpenseTypeTable()
        {
            int x = 0;
            string SQLCountExpenseType = "SELECT COUNT(*) ExpenseTypeTable;";
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
        public static int CountDataExpenseTable()
        {
            int x = 0;
            string SQLCountExpenseType = "SELECT COUNT(*) DataExpenseTable;";
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
        private static int GetExpenseTypeID(string tempName)
        {
            int tempID = 0;
            string SQLSelectExpenseType
            = "SELECT ExpenseTypeID FROM ExpenseTypeTable WHERE ExpenseTypeName = '" + tempName + "';";
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
        public static List<string> GetExpenseTypeList()
        {
            List<string> expenseTypeList = new List<string>();
            string SQLSelectExpenseType
            = "SELECT ExpenseTypeName FROM ExpenseTypeTable;";
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
        public static DataSet GetDataExpenses()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter;
            string SQLSelectExpenseType
            = "SELECT DataExpenseID, Date ,ExpenseTypeName, Price, Quantity " 
            + "FROM DataExpenseTable LEFT JOIN ExpenseTypeTable "
            + "ON DataExpenseTable.DataExpenseTypeID = ExpenseTypeTable.ExpenseTypeID;";
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
