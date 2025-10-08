using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class InstructorController : Controller
    {

        DBLG db = new DBLG();
        
        public IActionResult Index()
        {
           
            List<Instructor> instructors = db.GetInstructors();
            return View(instructors);
        }



        public IActionResult Details(int id)
        {
            
           Instructor instructor =db.GetInstructorById(id);

            if (instructor == null)
            {
                return NotFound();
            }
            return View("Details",instructor);
        }
    }
}
