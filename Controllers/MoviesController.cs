using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;
using WebMovie.Services.Interfaces;
using WebMovie.ViewModels;

namespace WebMovie.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMoviesService _moviesService;
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
			var movies = await _moviesService.GetAll();
			var ratings = await _ratingsService.GetAll();

			var moviesVM = new List<MoviesVM>();

			foreach (var movie in movies)
			{
				var rating = ratings.FirstOrDefault(r => r.MovieId == movie.Id);

				moviesVM.Add(new MoviesVM
				{
					Movie = movie,
					Rating = rating,
				});
			}

			return View(moviesVM);
		}
		public async Task<IActionResult> Create()
		{
			return View();
		}
	}
}
