using BlazorEmpwage.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorEmpwage.Services
{
    public class EmployeeServicecs : IEmployeeServices
    {
        private readonly HttpClient httpClient;

        public EmployeeServicecs(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetJsonAsync<Employee[]>(" / api / Employee / Index");
        }
    }
}
