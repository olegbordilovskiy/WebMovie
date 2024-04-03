using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;
using WebMovie.ViewModels;

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
            var moviesVM = new MoviesVM();
            moviesVM.Movies = _databaseContext.Movies.ToList();
            moviesVM.Ratings = _databaseContext.Ratings.ToList();
           
            return View(moviesVM);
        }
    }
}
