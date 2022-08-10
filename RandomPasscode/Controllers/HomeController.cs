using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers;

public class HomeController : Controller
{

    RandSTR randString = new RandSTR();
    public int number = 1;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // HttpContext.Session.SetInt32("gennum", number);
        return View("Index", randString);
    }

    public IActionResult Privacy()
    {
        return View();
    }


    public IActionResult GeneratePass() {
        randString.Generate();
        // number += 1;
        // HttpContext.Session.SetInt32("gennum", number);
        return View("Index", randString);
        // return Index();
    }
}
