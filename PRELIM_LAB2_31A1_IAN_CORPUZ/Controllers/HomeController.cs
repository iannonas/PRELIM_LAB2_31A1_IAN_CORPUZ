using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB2_31A1_IAN_CORPUZ.Models;
using PRELIM_LAB2_31A1_IAN_CORPUZ.Models;

namespace PRELIM_LAB2_31A1_IAN_CORPUZ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Book book = new Book
            {
                Id = 1,
                Title = "I Love You Since 1892",
                Author = "Binibining Mia"
            };

            Customer customer = new Customer
            {
                FirstName = "Ian",
                LastName = "Corpuz",
                MiddleName = "B.",
                Title = "Mr.",
                Email = "ian.corpuz1505@gmail.com"
            };

            var model = (book, customer);
            return View(model);
        }
    }
}
