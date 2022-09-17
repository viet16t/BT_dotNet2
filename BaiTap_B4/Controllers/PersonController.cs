using BaiTap_B4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
namespace BaiTap_B4.Controllers{
    public class PersonController : Controller{
        [HttpPost]
        public IActionResult Index(Person per){
            string message = per.Name+ "-";
            message += per.Age;
            message += per.QueQuan +"-";
            ViewBag.TT = message;
            return View();
        }
    }
}