using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SuperFlange
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private OleDbConnection connection;
        

        private DatabaseConnection()
        {
            try
            {
                connection = new OleDbConnection();
                connection.ConnectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ AppDomain.CurrentDomain.BaseDirectory }\bbs.accdb;
                Persist Security Info=False;";
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static DatabaseConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }

            return instance;
        }

        public void ExectueQuery(string query)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(2));
            }
        }
    }
}
