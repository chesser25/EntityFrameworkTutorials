namespace EF_CodeFirst_Tutorial_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Student student = new Student() { StudentName = "Helena" };

                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
