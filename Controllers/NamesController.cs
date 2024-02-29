using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;

namespace WebMovie.Controllers
{
    public class NamesController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        public NamesController(DatabaseContext databaseContext)
        {
                _databaseContext = databaseContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
