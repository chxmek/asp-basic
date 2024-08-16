using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicASPTutorial.Models
{
    public class Student                   // ใน sql ชื่อ model จะเป็นชื่อตาราง
    {
        [Key]                              // ระบุ data annotation ชื่อว่า Key คือต้องการให้ props Id เป็นรูปแบบ primary key >> สร้างรหัส(Id)ให้อัตโนมัติ
        public int Id { get; set; }        // ชื่อ property จะเป็นชื่อ column ในตารางนั้นๆ

        [Required]                         // Name ห้ามเป็นค่าว่าง
        [DisplayName("ชื่อนักเรียน")]           // เปลี่ยนเป้นข้อความภาษาไทย
        public string Name { get; set; }

        [DisplayName("คะแนนสอบ")]
        [Range(0,100)]                     // ระบุช่วง 0-100 ถ้าเป็นอย่างอื่นจะไม่สามารถเก็บใน database ได้
        public int Score { get; set; }
    }
}
