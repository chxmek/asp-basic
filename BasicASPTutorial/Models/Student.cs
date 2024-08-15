using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    public class Student                   // ใน sql ชื่อ model จะเป็นชื่อตาราง
    {
        [Key]                              // ระบุ data annotation ชื่อว่า Key คือต้องการให้ props Id เป็นรูปแบบ primary key >> สร้างรหัส(Id)ให้อัตโนมัติ
        public int Id { get; set; }        // ชื่อ property จะเป็นชื่อ column ในตารางนั้นๆ
        [Required]                         // Name ห้ามเป็นค่าว่าง
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
