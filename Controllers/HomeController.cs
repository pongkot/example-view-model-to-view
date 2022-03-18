using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelToView.Models;

namespace ViewModelToView.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Users()
    {
        IndexUsersView data = new IndexUsersView
        {
            TitlePage = "Users",
            Users = new List<User> {
                new User
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john.doe@mail.cc",
                },
                new User
                {
                    Id = 2,
                    Name = "Mr. Brown",
                    Email = "mrbrown@mail.cc",
                },
                new User
                {
                    Id = 3,
                    Name = "Jane Doe",
                    Email = "jane.doe@mail.cc",
                }
            }
        };
        return View(data);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
