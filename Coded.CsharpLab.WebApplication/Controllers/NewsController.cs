using Microsoft.AspNetCore.Mvc;

namespace Coded.CsharpLab.WebApplication.Controllers;

public class NewsController : Controller
{
    // GET
    public IActionResult Index()
    {
      return View();
    }
    
    public IActionResult Details(int id)
    {
        ViewBag.Id = id;
        return View();
    }
}