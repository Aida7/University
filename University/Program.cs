using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UniverContext())
            {
                db.Groups.Add(new Group{ Id = 1, Name="db3-3",Сourse="2"});
                db.SaveChanges();
                db.Students.Add(new Student { Id=1,GroupId=1,Сourse="2" ,Name="g"});
                db.SaveChanges();
                db.Teachers.Add(new Teacher { Id = 1, Experience = "1", GroupId = 1, Name = "Stud", Position = "1" });
                db.SaveChanges();
                db.Subjects.Add(new Subject { Id = 1,Name="geometry",TeacherId=1});
                db.SaveChanges();
                db.Schedules.Add(new Schedule { Id = 1, GroupId=1,SubjectId=1,TeacherId=1,Time=DateTime.Now, });
                db.SaveChanges();
            }
        }
    }
}
