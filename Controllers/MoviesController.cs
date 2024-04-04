using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;
using WebMovie.Services.Interfaces;
using WebMovie.ViewModels;

namespace WebMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly  IMoviesService _moviesService;
        private readonly IRatingsService _ratingsService;
        public MoviesController(IMoviesService moviesService, IRatingsService ratingsService)
        {
            _moviesService = moviesService;   
            _ratingsService = ratingsService;
        }

        public async Task<IActionResult> Index()
        {
            var moviesVM = new MoviesVM();
            moviesVM.Movies = await _moviesService.GetAll();
            moviesVM.Ratings = await _ratingsService.GetAll();
           
            return View(moviesVM);
        }
    }
}
