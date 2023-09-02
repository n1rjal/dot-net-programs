
using Microsoft.AspNetCore.Mvc;
using Lab_16.Models;

namespace Lab_16.Controllers;

public class HomeController : Controller
{
    //GET:Home
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Employee e)
    {
        if (ModelState.IsValid == true)
        {
            ViewData["SuccessMessage"] = "<script>alert('Data has been submitted')</script>";
        ModelState.Clear();
        }
        return View();
    }
}
