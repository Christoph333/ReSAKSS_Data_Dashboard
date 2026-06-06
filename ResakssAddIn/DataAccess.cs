using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
namespace ResakssAddIn
{
    class DataAccess
    {
        public static void InitializeDatabase()
        {
           /* using (SqliteConnection db =
                new SqliteConnection("Filename=ResakssDB.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable2 (Primary_Key INTEGER NULL, " +
                    "Text_Entry NVARCHAR(2048) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
                // Use parameterized query to prevent SQL injection attacks
                String insertCommand = "INSERT INTO MyTable2 (Primary_Key, Text_Entry) VALUES (11, \"chris\");";
                createTable = new SqliteCommand(insertCommand, db);
               // createTable.Parameters.AddWithValue("11", "Christ");

                createTable.ExecuteReader();
            }
            */
        }
    }
}
