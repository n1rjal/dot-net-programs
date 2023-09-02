using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
namespace ValidationMessage.Controllers
{
    public class HomeController : Controller
    {
        string EmailPattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a - z0 - 9])?$";
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string FullName, string Age, string Email)
        {
            if (FullName == null)
            {
                ModelState.AddModelError("FullName", "Fullname must be provided!!");
                ViewData["FullNameError"] = "*";
            }
            if (Age == null)
            {
                ModelState.AddModelError("Age", "Age must be provided!!");
                ViewData["AgeError"] = "*";
            }
            if (Email == null)
            {
                ModelState.AddModelError("Email", "Email must be provided!!");
                ViewData["EmailError"] = "*";
            }
            else
            {
                if (Regex.IsMatch(Email, EmailPattern) == false)
                {
                    ModelState.AddModelError("Email", "Email doesn't obey rules!!");
                    ViewData["EmailError"] = "*";
                }
            }
            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data submitted successfully')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}