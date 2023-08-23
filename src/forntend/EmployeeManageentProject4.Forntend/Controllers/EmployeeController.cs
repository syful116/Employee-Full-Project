using Microsoft.AspNetCore.Mvc;

namespace EmployeeManageentProject4.Forntend.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
