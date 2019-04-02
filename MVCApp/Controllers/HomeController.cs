using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;
using DataLibrary;
using static DataLibrary.Business_Logic.EmployeeProcessor;

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

        public ActionResult SignUp()
        {
            ViewBag.Message = "Your Signup page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
               int rowsCreated = CreateEmployee(model.EmployeeId, model.FirstName, model.LastName, model.EmailAddress, model.Password);

               return RedirectToAction("Index");
            }
            

            return View();
        }

        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Your Employee List.";
            var employees = LoadEmployee();
            List<EmployeeModel> employeeModels = new List<EmployeeModel>();
            foreach (var row in employees)
            {
                employeeModels.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    EmailAddress = row.EmailAddress,
                    ConfirmEmailAddress = row.EmailAddress
                });
            }

            return View(employeeModels);
        }
    }
}