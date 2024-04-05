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
        private readonly IDirectorsService _directorsService;
		private readonly IRolesService _rolesService;
		public MoviesController(IMoviesService moviesService, IRatingsService ratingsService, IDirectorsService directorsService, IRolesService rolesService)
        {
            _moviesService = moviesService;   
            _ratingsService = ratingsService;
            _directorsService = directorsService;
            _rolesService = rolesService;
        }

        public async Task<IActionResult> Index()
        {
			// transfer only the first 250
			var moviesVM = new MoviesVM();
            moviesVM.Movies = await _moviesService.GetAll();
            moviesVM.Ratings = await _ratingsService.GetAll();
           
            return View(moviesVM);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
