namespace MVC.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int DepartmentID { get; set; }



        public Department? Department { get; set; }

        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<CRS_Result> CRS_Results { get; set; }

        

    }
}
