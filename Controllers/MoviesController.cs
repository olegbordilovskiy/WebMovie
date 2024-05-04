using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;
using WebMovie.ViewModels.Movies;

namespace WebMovie.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMoviesService _moviesService;
		private readonly IRatingsService _ratingsService;
		private readonly IDirectorsService _directorsService;
		private readonly IRolesService _rolesService;
		private readonly IProducersService _producersService;
		private readonly INamesService _namesService;
		private readonly IWritersService _writersService;


		public MoviesController(IMoviesService moviesService, IRatingsService ratingsService,
			IDirectorsService directorsService, IRolesService rolesService
			, INamesService namesService, IProducersService producersService, IWritersService writersService)
		{
			_moviesService = moviesService;
			_ratingsService = ratingsService;
			_directorsService = directorsService;
			_rolesService = rolesService;
			_namesService = namesService;
			_producersService = producersService;
			_writersService = writersService;
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
				});
			}

			return View(moviesVM);
		}
		public async Task<IActionResult> Create()
		{
			var names = await _namesService.GetAll();
			//var directors = await _directorsService.GetAll();
			//var writers = await _writersService.GetAll();
			//var roles = await _rolesService.GetAll();
			//var producers = await _producersService.GetAll();

			var createMovieMV = new CreateMovieVM();

			//var directorsDictionary = names
			//	.Where(n => directors
			//	.Any(d => d.Name == n))
			//	.Select(n => new { n.FullName, n.Id })
			//	.Distinct()
			//	.Order()
			//	.ToDictionary(n => n.Id, n => n.FullName);

			//var writersDictionary = names
			//	.Where(n => writers
			//	.Any(d => d.Name == n))
			//	.Select(n => new { n.FullName, n.Id })
			//	.Distinct()
			//	.Order()
			//	.ToDictionary(n => n.Id, n => n.FullName);

			//var rolesDictionary = names
			//	.Where(n => roles
			//	.Any(d => d.Name == n))
			//	.Select(n => new { n.FullName, n.Id })
			//	.Distinct()
			//	.Order()
			//	.ToDictionary(n => n.Id, n => n.FullName);

			//var producersDictionary = names
			//	.Where(n => producers
			//	.Any(d => d.Name == n))
			//	.Select(n => new { n.FullName, n.Id })
			//	.Distinct()
			//	.Order()
			//	.ToDictionary(n => n.Id, n => n.FullName);

			//ViewBag.Directors = directorsDictionary;
			//ViewBag.Writers = writersDictionary;
			//ViewBag.Producers = producersDictionary;
			//ViewBag.Roles = rolesDictionary;

			ViewBag.Names = names;

			return View(createMovieMV);
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateMovieVM model)
		{
			//if (!ModelState.IsValid)
			{
				//	return View();
			}
			var movie = model.Movie;
			var directorsId = model.Directors;
			var names = await _namesService.GetAll();
			var directorsNames = names.Where(n => directorsId.Contains(n.Id));

			_moviesService.Add(movie);
			foreach (var directorName in directorsNames)
			{
				_directorsService.Add(new Director { Movie = movie, Name = directorName });
			}

			return RedirectToAction("Index");
		}
	}
}
