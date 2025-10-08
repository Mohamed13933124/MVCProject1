namespace MVC.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int  Salary { get; set; }
        public string? address { get; set; }
        public int DepartmentID { get; set; }
        public int CourceID { get; set; }


        public Department? Department { get; set; }
        public Course? Course { get; set; }


    }
}
