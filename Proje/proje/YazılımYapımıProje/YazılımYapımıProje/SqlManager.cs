using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımYapımıProje
{
    public class SqlManager
    {
        private SqlConnection Connection;
        public SqlManager(SqlConnection connection)
        {
            this.Connection = connection;
        }

        public void PrintToDatabase(SqlCommand command)
        {
            Connection.Open();
        }
        public Dictionary<string, string> ReadDatabase(string commandText)
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            Connection.Open();
            SqlCommand command = new SqlCommand(commandText, Connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();

            if (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    info.Add(Convert.ToString(sqlDataReader.GetName(i)),
                             Convert.ToString(sqlDataReader[i]));
                }
                Connection.Close();
                return info;
            }
            else
            {
                Connection.Close();
                return null;
            }
        }

        public void Update(string commandText)
        {
            Connection.Open();
            SqlCommand command = new SqlCommand(commandText, Connection);
            command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
