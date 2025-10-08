namespace MVC.Models
{
    public class DBLG
    {
        Context context = new Context();
        List<Instructor> Instructors { get; set; }

        public DBLG()
        {
            Instructors=new List<Instructor>();

        }

        public List<Instructor> GetInstructors()
        {
            Instructors = context.Instructors.ToList();
            return Instructors;
        }

        public Instructor? GetInstructorById(int id)
        {
            return context.Instructors.FirstOrDefault(i => i.ID == id);
        }

    }
}
