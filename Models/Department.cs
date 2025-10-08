﻿namespace MVC.Models
{
    public class Department
    {
        public int ID    { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }


        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Trainee> Trainees { get; set; }
        public ICollection<Course> Courses { get; set; }



    }
}
