using System.Collections.Generic;

namespace EF_CodeFirst_Tutorial_1_
{
    class Standard
    {
        public Standard() { }

        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
