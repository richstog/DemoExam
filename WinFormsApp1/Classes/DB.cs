using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WinFormsApp1.Classes
{
    public class DB
    {
        private NpgsqlConnection conn = new NpgsqlConnection("host=localhost;port=5432;username=postgres;password=rhfcbkjdf29;database=DemExam;");

        public void openConnection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return conn;
        }
    }
}
