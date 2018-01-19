using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst_Tutorial_1_
{
    [Table("StudentInfo")]
    class Student
    {
        public Student() { }

        [Key]
        public int StudId { get; set; }

        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string StudentName { get; set; }

        [NotMapped]
        public DateTime? DateOfBirth { get; set; }

        public byte[] Photos { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int IQ { get; set; }

        //public int StandardId { get; set; }

        //[ForeignKey("StandardId")]
        public virtual Standard Standard { get; set; }

        public Teacher Teacher { get; set; }
    }
}
