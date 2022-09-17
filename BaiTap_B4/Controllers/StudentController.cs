using System.Reflection.Metadata.Ecma335;
using BaiTap_B4.Models;
using Microsoft.AspNetCore.Mvc;
namespace BaiTap_B4.Controllers
{
    public class StudentController : Controller{
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std){
            string message = std.StudentID + "-";
            message += std.StudentName + "-";
            message += std.Age;
            ViewBag.TT = message;
            return View();
        }
    }
}