﻿using System;
using System.Collections.Generic;
using System.Linq;
using BlazorEmpwage.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BlazorEmpwage
{
    public class EmpService
    {
        string connectionString = "Data Source=LAPTOP-NAVJ6800\\SQLEXPRESS;Initial Catalog=Blazor;Integrated Security=True;";
        public void Create(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Insert into Employee values ('" + employee.Name + "','" + employee.Gender + "' ) ");
                cmd.ExecuteNonQuery();
            }
        }
    }
}
