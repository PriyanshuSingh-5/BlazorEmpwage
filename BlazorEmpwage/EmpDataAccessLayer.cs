using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage
{
    public class EmpDataAccessLayer
    {
        // string connectionString = "Put Your Connection string here";
        string connectionString = "Data Source=LAPTOP-NAVJ6800\\SQLEXPRESS;Initial Catalog=Blazor;Integrated Security=True;";
        //To View all Customers details    
        public IEnumerable<Employee> GetAllEmployee()
        {
            List<Employee> lstCustomer = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Employee Emp = new Employee();
                    Emp.CustomerId = Convert.ToInt32(rdr["CustomerID"]);
                    Emp.Name = rdr["Name"].ToString();
                    Emp.Gender = rdr["Gender"].ToString();
                    //Customer.Country = rdr["Country"].ToString();
                    Emp.City = rdr["City"].ToString();
                    lstCustomer.Add(Emp);
                }
                con.Close();
            }
            return lstCustomer;
        }
        //To Add new Customer record    
        public void AddEmployee(Employee Customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                //cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@City", Customer.City);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar Customer  
        public void UpdateEmployee(Employee Customer)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", Customer.CustomerId);
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                //cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular Customer  
        public Employee GetEmployeeData(int? id)
        {
            Employee Customer = new Employee();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("usp_GetCustomerByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customer.CustomerId = Convert.ToInt32(rdr["CustomerID"]);
                    Customer.Name = rdr["Name"].ToString();
                    Customer.Gender = rdr["Gender"].ToString();
                    //Customer.Country = rdr["Country"].ToString();
                    Customer.City = rdr["City"].ToString();
                }
            }
            return Customer;
        }
        //To Delete the record on a particular Customer  
        public void DeleteEmployee(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_DeleteEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
  
