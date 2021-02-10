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
    class SQLiteInventoryClass
    {
        private const string SQLCreateTableInventory
            = "CREATE TABLE InventoryTable"
            + "(InventoryID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL,"
            + "Date TEXT NOT NULL,"
            + "InventoryItemID INTEGER NOT NULL,"
            + "InventoryQuantity INTEGER NOT NULL);";
        private const string SQLCreateTableSales
            = "CREATE TABLE SalesTable"
            + "(SalesID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL,"
            + "Date TEXT NOT NULL,"
            + "MenuItemID INTEGER NOT NULL,"
            + "SaleQuantity INTEGER NOT NULL);";
        public static void CreateTable()
        {
            SQLiteConnectionClass.SQLExecuteCommand(SQLCreateTableInventory);
            SQLiteConnectionClass.SQLExecuteCommand(SQLCreateTableSales);
        }
        public static void InsertMenuItem(int TempMenuItemID, string TempDate)
        {
            string SQLInsertNewMenuItem
            = "INSERT INTO InventoryTable"
            + " (InventoryItemID, Date, InventoryQuantity)"
            + " VALUES ( '" + TempMenuItemID + "' , '"+ TempDate + "','0');";
            SQLiteConnectionClass.SQLExecuteCommand(SQLInsertNewMenuItem);
        }
        public static void updateStock(int addStock, string comboBoxName)
        {
            string SQLUpdateStock
            = "UPDATE InventoryTable"
            + " SET InventoryQuantity = '" + (getCurrentStock(comboBoxName) + addStock) + "' "
            + " WHERE InventoryItemID = '" + SQLiteRawMatsClass.GetMenuItemID(comboBoxName) + "';";
            SQLiteConnectionClass.SQLExecuteCommand(SQLUpdateStock);
        }
        public static int getCurrentStock(string comboBoxName)
        {
            int tempID = SQLiteRawMatsClass.GetMenuItemID(comboBoxName);
            int x = 0;
            string currentStock = "SELECT InventoryQuantity FROM InventoryTable WHERE InventoryItemID = '" + tempID + "';";
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = SQLiteConnectionClass.OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = currentStock;
            SQLiteDataReader SQLREADER = SQLCMD.ExecuteReader();
            while (SQLREADER.Read())
            {
                x = SQLREADER.GetInt32(0);
            }
            return x;
        }
        public static void InsertSalesItem(string comboBoxValue, int addStock, string tempDate)
        {
            string SQLInsertSalesItem
            = "INSERT INTO SalesTable"
            + " (MenuItemID, SaleQuantity, Date)"
            + " VALUES ( '" + SQLiteRawMatsClass.GetMenuItemID(comboBoxValue) + "' ,'"+ addStock + "','" + tempDate + "');";
            SQLiteConnectionClass.SQLExecuteCommand(SQLInsertSalesItem);
        }
        public static int CountInventoryTable()
        {
            int x = 0;
            string SQLCountExpenseType = "SELECT COUNT(*) InventoryTable;";
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
        public static DataSet GetDataInventory()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter;
            string SQLSelectExpenseType
            = "SELECT InventoryID, Date, MenuItemName AS 'Item Name', InventoryQuantity AS 'Inventory Quantity'"
            + "FROM InventoryTable LEFT JOIN MenuItemTable "
            + "ON InventoryTable.InventoryItemID = MenuItemTable.MenuItemID;";
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
