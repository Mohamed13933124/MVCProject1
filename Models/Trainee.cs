namespace MVC.Models
{
    public class Trainee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string image { get; set; }
        public string address { get; set; }
        public int grade { get; set; }
        public int DepartmentID { get; set; }

        public Department? Department { get; set; }
        public ICollection<CRS_Result> CRS_Results { get; set; }

    }
}
