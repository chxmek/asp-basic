﻿using BasicASPTutorial.Models;
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
            Student s1 = new();             // สร้าง object ได้ทั้งหมด 3 รูปแบบดังนี้
            s1.Id = 1;
            s1.Name = "เมฆ";
            s1.Score = 80;

            var s2 = new Student();
            s2.Id = 2;
            s2.Name = "โจโจ้";
            s2.Score = 45;

            Student s3 = new();
            s3.Id = 3;
            s3.Name = "เจน";
            s3.Score = 50;

            List<Student> allStudent = new List<Student>();     // List allStudent จะสามารถเก็บข้อมูลได้เฉพาะ object จาก class Student
            allStudent.Add(s1);
            allStudent.Add(s2);
            allStudent.Add(s3);

            return View(allStudent);                          // ด้านบนเป็นวิธีการส่ง object หลายๆก้อนไปทำงานที่ View 
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
