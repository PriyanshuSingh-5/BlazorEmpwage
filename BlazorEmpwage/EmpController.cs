using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEmpwage
{
    public class EmpController : Controller
    {
        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}
        EmpDataAccessLayer objemployee = new EmpDataAccessLayer();

        [HttpGet]
        [Route("api/Employee/Index")]
        public IEnumerable<Employee> Index()
        {
            return objemployee.GetAllEmployee();
        }

        [HttpPost]
        [Route("api/Employee/Create")]
        public void Create([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
                objemployee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("api/Employee/Details/{id}")]
        public Employee Details(int id)
        {

            return objemployee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("api/Employee/Edit")]
        public void Edit([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
                objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public void Delete(int id)
        {
            objemployee.DeleteEmployee(id);
        }
    }
}

