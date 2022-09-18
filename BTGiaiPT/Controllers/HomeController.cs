using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTGiaiPT.Models;

namespace BTGiaiPT.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(/*string heSoA, string heSoB, string heSoC*/)
    {
        /*double a, b, c;
        double delta; delta = b*b - 4*a*c;
        a = Convert.ToDouble(heSoA);
        b = Convert.ToDouble(heSoB);
        b = Convert.ToDouble(heSoC);*/
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
    public IActionResult GiaiPhuongTrinhBac1()
    {
        
        return View();
    }
    public IActionResult GiaiPhuongTrinhBac2()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GiaiPhuongTrinhBac1(String heSoA, string heSoB, string heSoC)
    {
        GiaiPhuongTrinhBac1 gpt1 = new GiaiPhuongTrinhBac1();
        string thongBaoPTBN = gpt1.GiaiPhuongTrinhBacNhat(heSoA, heSoB);
        ViewBag.Message = thongBaoPTBN;
        return View();
    }
    public IActionResult GiaiPhuongTrinhBac2(String heSoA, string heSoB, string heSoC)
    {
        GiaiPhuongTrinhBac2 gpt2 = new GiaiPhuongTrinhBac2();
        string thongBaoPTB2 = gpt2.GiaiPhuongTrinhBacHai(heSoA, heSoB, heSoC);
        ViewBag.Message = thongBaoPTB2;
        return View();
    }
}
