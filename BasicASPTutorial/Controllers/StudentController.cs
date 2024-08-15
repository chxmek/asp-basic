using BasicASPTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicASPTutorial.Controllers
{
    public class StudentController : Controller     // StudentController สืบทอดคุณสมบัติมาจาก Controller
    {
        //public IActionResult Index()                // มี Action method ชื่อว่า Index ในรูปแบบ IActionResult >> ส่งเป้นหน้าเว็ปออกมา 
        //{
        //    return View();                          // มีคำสั่ง return View()
        //}
        public IActionResult Index()                // มี Action method ชื่อว่า Index ในรูปแบบ IActionResult >> ส่งเป้นหน้าเว็ปออกมา 
        {
            var s1 = new Student();
            return View();                          // เรียกใช้ method Index แล้ว return View() ออกมาซึ่งอยู่ใน folder Views/Student/Index.cshtml
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
