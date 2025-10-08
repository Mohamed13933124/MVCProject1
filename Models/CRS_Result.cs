namespace MVC.Models
{
    public class CRS_Result
    {

        public int ID { get; set; }
        public int Degree { get; set; }
        public int Course_ID { get; set; }
        public int TraineeID { get; set; }

        public Course? Course { get; set; }
        public Trainee? Trainee { get; set; }



    }
}
