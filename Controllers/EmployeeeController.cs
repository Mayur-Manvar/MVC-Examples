using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class EmployeeeController : Controller
    {
        public ActionResult GetAllEmployee()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employee = employeeContext.Employees.ToList();

            return View(employee);
        }
        // GET: Employeee
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(x => x.EmpId == id);

            return View(employee);
        }
    }
}