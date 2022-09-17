using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiTap_B4.Models;

namespace BaiTap_B4.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpGet]
    public IActionResult Create(){
        return View();
    }
    [HttpPost]
    public IActionResult Create(string FullName){
        string message = "Xin chào "+FullName;
        //Sử dụng ViewBag để gửi dữ liệu từ Controller
        ViewBag.ThongBap = message;
        return View();
    }
}
