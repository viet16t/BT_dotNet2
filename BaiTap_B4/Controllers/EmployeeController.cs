using BaiTap_B4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
namespace BaiTap_B4.Controllers{
    public class EmployeeController : Controller {
        [HttpPost]
        public IActionResult Index(Employee emp){
            string message = emp.ID + "-";
            message += emp.Name + "-";
            message += emp.ViTri + "-";
            ViewBag.TT = message;
            return View();

        }
    }
}