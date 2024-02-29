using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;

namespace WebMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public MoviesController(DatabaseContext databasecontext)
        {
            _databaseContext = databasecontext;           
        }

        public IActionResult Index()
        {
            var data = _databaseContext.Movies.ToList();
            return View();
        }
    }
}
