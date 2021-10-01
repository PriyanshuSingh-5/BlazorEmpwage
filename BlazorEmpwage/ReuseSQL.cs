using BlazorEmpwage.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage
{
    public class ReuseSQL
    {
        public static SQLConnConfig _conn;
        public SqlConnection connection;
        private SqlConnection connnection;

        public ReuseSQL(SQLConnConfig conn)
        {
            _conn = conn;
            connection = new SqlConnection(_conn.Value);
        }

        public async Task SaveRecord(string SQLStr)
        {
            connection.Open();
                SqlCommand cmd = new SqlCommand("SQLStr", connection);
                cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        public DataTable GetRecord(string SQLStr)
        {
           
                SqlCommand cmd = new SqlCommand(SQLStr, connnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

