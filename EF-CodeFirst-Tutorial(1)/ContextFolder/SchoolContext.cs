using System.Data.Entity;

namespace EF_CodeFirst_Tutorial_1_
{
    class SchoolContext: DbContext
    {
        public SchoolContext(): base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseIfModelChanges<SchoolContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
    }
}
