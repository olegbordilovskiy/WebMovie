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
		private readonly INamesService _namesService;

		public MoviesController(IMoviesService moviesService, IRatingsService ratingsService, IDirectorsService directorsService, IRolesService rolesService, INamesService namesService)
		{
			_moviesService = moviesService;
			_ratingsService = ratingsService;
			_directorsService = directorsService;
			_rolesService = rolesService;
			_namesService = namesService;
		}

		public async Task<IActionResult> Index()
		{
			var movies = await _moviesService.GetAll();
			var ratings = await _ratingsService.GetAll();
			var directors = await _directorsService.GetAll();
			var names = await _namesService.GetAll();

			var moviesVM = new List<MoviesVM>();

			foreach (var movie in movies)
			{
				var rating = ratings.FirstOrDefault(r => r.MovieId == movie.Id);
				var directorList = directors.Where(d => d.Movie == movie);
				var directorNames = names.Where(n => directorList.Any(d => d.Name == n)).Select(n => n.FullName).ToList(); 

				moviesVM.Add(new MoviesVM
				{
					Movie = movie,
					Rating = rating,
					Directors = directorNames
				}) ;
			}

			return View(moviesVM);
		}
		public async Task<IActionResult> Create()
		{
			return View();
		}
	}
}
