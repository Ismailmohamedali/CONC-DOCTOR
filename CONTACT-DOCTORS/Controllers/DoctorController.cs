using CONTACT_DOCTORS.Data;
using Microsoft.AspNetCore.Mvc;

namespace CONTACT_DOCTORS.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var doc =  context.Doctors.ToList();
            return View(model: doc);
        }
    }
}
