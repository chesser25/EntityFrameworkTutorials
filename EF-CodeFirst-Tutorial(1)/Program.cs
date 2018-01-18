using System;

namespace EF_CodeFirst_Tutorial_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Student student = new Student() { StudentName = "Anna" };

                context.Students.Add(student);
                context.SaveChanges();
                foreach(var stud in context.Students)
                {
                    Console.WriteLine(stud.StudentName);
                    Console.ReadLine();
                }
            }
        }
    }
}
