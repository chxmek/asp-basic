using BasicASPTutorial.Data;
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

        private readonly ApplicationDBContext _db;

        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()                // มี Action method ชื่อว่า Index ในรูปแบบ IActionResult >> ส่งเป้นหน้าเว็ปออกมา 
        {
            Student s1 = new();             // สร้าง object ได้ทั้งหมด 3 รูปแบบดังนี้
            s1.Id = 1;
            s1.Name = "เมฆ";
            s1.Score = 80;

            var s2 = new Student();
            s2.Id = 2;
            s2.Name = "โจโจ้";
            s2.Score = 45;


            List<Student> allStudent = new List<Student>();     // List allStudent จะสามารถเก็บข้อมูลได้เฉพาะ object จาก class Student
            allStudent.Add(s1);
            allStudent.Add(s2);

            return View(allStudent);                          // ด้านบนเป็นวิธีการส่ง object หลายๆก้อนไปทำงานที่ View 
        }
        // GET METHOD เป็น Default
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            _db.Students.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
