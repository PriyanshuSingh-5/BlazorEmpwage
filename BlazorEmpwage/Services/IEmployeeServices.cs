using System;
using BlazorEmpwage.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage.Services
{
   public  interface IEmployeeServices
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
