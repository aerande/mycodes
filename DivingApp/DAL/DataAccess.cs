using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccess
    {
        public static DataTable SelectData(string query, List<SqlParameter> param)
        {
            //string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aniru\Downloads\DivingApp\DivingWeb\App_Data\Database.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection connection = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand(query, connection);
            foreach (SqlParameter par in param)
            {
                command.Parameters.Add(par);
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.Open();
            adapter.Fill(dt);
            connection.Close();

            return dt;
        }

        public static int ModifyData(string query, List<SqlParameter> param)
        {
            string connStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True";

            SqlConnection connection = new SqlConnection(connStr);
            SqlCommand command = new SqlCommand(query, connection);
            foreach (SqlParameter par in param)
            {
                command.Parameters.Add(par);
            }

            connection.Open();
            int x = command.ExecuteNonQuery();
            connection.Close();

            return x;
        }

    }
}
