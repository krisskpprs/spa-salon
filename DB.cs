using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace spa_salon
{
    internal class DB
    {
        SqlConnection SqlConnection=new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SPA;Integrated Security=True;");

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                SqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }
        public SqlConnection GetSqlConnection() 
        {
            return SqlConnection;   
        }



    }
}
