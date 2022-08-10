using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers;

public class HomeController : Controller
{

    RandSTR randString = new RandSTR();

    public IActionResult Index()
    {
        HttpContext.Session.SetInt32("gennum", 1);
        return View("Index", randString);
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult GeneratePass() {
        randString.Generate();
        int? number =  HttpContext.Session.GetInt32("gennum");
        if (number == null) {
            number = 1;
        }
        HttpContext.Session.SetInt32("gennum", (int)number + 1);
        return View("Index", randString);
        // return Index();
    }
}
