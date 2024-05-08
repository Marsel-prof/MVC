using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public EmpContext db= new EmpContext();
        public IActionResult Index()
        {
            var emp = db.Employees.ToList();
            return View("Show",emp);
        }
    }
}
