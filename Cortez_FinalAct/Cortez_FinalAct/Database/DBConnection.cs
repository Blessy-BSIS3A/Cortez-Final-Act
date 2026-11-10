using System;
using System.Data.OleDb;
using System.IO;

namespace Cortez_FinalAct
{
    public static class DBConnection
    {
        private static readonly string DatabasePath = Path.Combine(
            AppContext.BaseDirectory,
            "Database",
            "CortezInventoryDB.accdb");

        private static readonly string ConnectionString =
            new OleDbConnectionStringBuilder
            {
                ["Provider"] = "Microsoft.ACE.OLEDB.12.0",
                ["Data Source"] = DatabasePath,
                ["Persist Security Info"] = false
            }.ConnectionString;

        public static OleDbConnection GetConnection()
        {
            if (!File.Exists(DatabasePath))
            {
                throw new FileNotFoundException(
                    $"Database file was not found: {DatabasePath}",
                    DatabasePath);
            }

            return new OleDbConnection(ConnectionString);
        }
    }
}