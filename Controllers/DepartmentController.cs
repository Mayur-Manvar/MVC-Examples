using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult GetDepartment()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> employee = employeeContext.Departments.ToList();

            return View(employee);
            
        }
    }
}