using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace COE131L_PROJECT.Classes
{
    class SQLiteConnectionClass
    {
        public static void DatabaseCheck()
        {
            string pathString = Directory.GetCurrentDirectory();
            Directory.CreateDirectory("Database");
            pathString = Path.Combine(pathString, "Database");
            pathString = Path.Combine(pathString, "COE131LDatabase.db");
            if (!File.Exists(pathString))
            {
                SQLiteConnection.CreateFile(@"Database\COE131LDatabase.db");
                SQLiteExpensesClass.CreateTable();
                SQLiteRawMatsClass.CreateTable();
            }
        }
        public static void SQLExecuteCommand(string SQLCommand)
        {
            SQLiteCommand SQLCMD;
            SQLiteConnection SQLConnection = OpenSQLConnection();
            SQLCMD = SQLConnection.CreateCommand();
            SQLCMD.CommandText = SQLCommand;
            SQLCMD.ExecuteNonQuery();
            CloseSQLConnection(SQLConnection);
        }
        public static SQLiteConnection OpenSQLConnection()
        {
            SQLiteConnection SQLConnection = new SQLiteConnection(@"Data Source=Database\COE131LDatabase.db;Version=3;New=True;Compress=True;");
            try
            {
                SQLConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error", "Error Code: " + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return SQLConnection;
        }
        public static void CloseSQLConnection(SQLiteConnection SQLconn)
        {
            if (SQLconn != null)
            {
                SQLconn.Close();
            }
        }
    }
}
