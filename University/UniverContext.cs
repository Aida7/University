namespace University
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UniverContext : DbContext
    {
        public UniverContext()
            : base("name=UniverContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}