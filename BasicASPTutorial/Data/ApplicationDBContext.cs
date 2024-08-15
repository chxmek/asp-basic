using BasicASPTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicASPTutorial.Data
{
    public class ApplicationDBContext : DbContext
    {
        // constructor ApplicationDBContext มีการระบุ DbContextOptions เป็นรูปแบบของ <ApplicationDBContext> ตั้งชื่อว่า options แล้วส่งค่าไปทำงานยัง classแม่(base)
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){

        }
        // นำ Model Student ไปสร้างเป็นตารางเก็บใน database ที่มีชื่อว่า Students
        public DbSet<Student> Students { get; set; }
    }
}
