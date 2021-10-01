using System;
using System.Collections.Generic;
using System.Linq;
using BlazorEmpwage.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BlazorEmpwage
{
    public class EmpService
    {
        public static SQLConnConfig _conn;
        public SqlConnection connection;
        private SqlConnection connnection;

        public EmpService(SQLConnConfig conn)
        {
            _conn = conn;
            connection = new SqlConnection(_conn.Value);
        }

        public List<Employee> GetEmployeesList()
        {
            List<Employee> employees = new List<Employee>();
            SqlCommand cmd = new SqlCommand("Select * from Employee", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt != null && dt.Rows.Count>0)
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    Employee employee = new Employee();
                    employee.Name = dt.Rows[i]["Name"].ToString();
                    employee.Gender = dt.Rows[i]["Gender"].ToString();
                    employee.Department = dt.Rows[i]["Department"].ToString();
                    employee.Notes = dt.Rows[i]["Notes"].ToString();
                    employees.Add(employee);

                }
            }
            return employees;
        }

        public void SaveEmployee(Employee employee)
        {
            //using (var connection = new SqlConnection(@"Data Source=LAPTOP-NAVJ6800\\SQLEXPRESS;Initial Catalog=Blazor;Integrated Security=True;"))
            //{
                SqlCommand cmd = new SqlCommand("Insert into Employee values ('" + employee.Name + "','" + employee.Gender + "','" + employee.Department + "','" + employee.Notes + "') ",connection);
            connection.Open();
                cmd.ExecuteNonQuery();
            connection.Close();
            //}
        }
    }
}
