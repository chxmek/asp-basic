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
            return Content("คะแนนสอบวิชาคอมพิวเตอร์");    // เข้าไปที่ https://localhost:44353/student/index
        }
        public IActionResult Details()
        {
            return Content("รายละเอียดคะแนนสอบ");
        }
        public IActionResult ShowScore(int id)
        {
            return Content($"คะแนนสอบของนักเรียน เลขที่ {id}");     // เข้าไปที่ https://localhost:44353/student/showscore/ใส่ตัวเลข
        }
    }
}
