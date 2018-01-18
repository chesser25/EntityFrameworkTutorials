using System;
using System.ComponentModel.DataAnnotations;

namespace EF_CodeFirst_Tutorial_1_
{
    class Student
    {
        public Student() { }

        [Key]
        public int StudId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Standard Standard { get; set; }
        public Teacher Teacher { get; set; }
    }
}
