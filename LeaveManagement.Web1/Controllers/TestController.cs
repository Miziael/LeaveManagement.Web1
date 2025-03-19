using LeaveManagement.Web1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Bob The student",
                DateOfBirth = new DateTime(1998, 12, 16)
            };
            return View(data);
        }
    }
}
