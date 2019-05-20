using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign up";

            return View();
        }

        public ActionResult ViewEmployee()
        {
            ViewBag.Message = "List Of Employees";

            var data = LoadEmployees();
            List<EmployeeModel> employee = new List<EmployeeModel>();

            foreach (var item in data)
            {
                employee.Add(new EmployeeModel
                {
                    EmployeeId = item.EmployeeId,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    EmailAddress = item.EmailAddress,
                    ConfirmEmail = item.EmailAddress
                });
        }


            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                    int recordsCreated= CreateEmployee(
                    model.EmployeeId,
                    model.FirstName,
                    model.LastName,
                    model.EmailAddress);
              
                return RedirectToAction("Index");
            }
            return View();
        }
        
            
        

    }
}