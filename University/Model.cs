using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Time{ get; set; }
        public int GroupId { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public virtual Group Group { get; set; }
        public virtual  Teacher Teacher { get; set; }
        public virtual Subject Subjects { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Сourse { get; set; }
        public string Name { get;set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

    }
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual List<Schedule> Schedules { get; set; }


    }
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Experience { get; set; }
        public string Position { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public virtual List<Subject> Subjects{ get; set; }
        public virtual List<Schedule> Schedules { get; set; }

    }
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Сourse { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Schedule> Schedules { get; set; }

    }

}
