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
			//var ratings = await _ratingsService.GetAll();
			//var directors = await _directorsService.GetAll();
			//var names = await _namesService.GetAll();

			var moviesVM = new List<MoviesVM>();

			foreach (var movie in movies)
			{
				var rating = ratings.FirstOrDefault(r => r.MovieId == movie.Id);
				//var directorList = directors.Where(d => d.Movie == movie);
				//var directorNames = names.Where(n => directorList.Any(d => d.Name == n)).Select(n => n.FullName).ToList();

				moviesVM.Add(new MoviesVM
				{
					Movie = movie,
					Rating = rating,
					//Directors = directorNames
				});
			}

			return View(moviesVM);
		}
		public async Task<IActionResult> Create()
		{
			var names = await _namesService.GetAll();
			var createMovieMV = new CreateMovieVM();

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
			var rating = model.Rating;
			//movie.Rating = rating;
			rating.Movie = movie;

			var directorsId = model.Directors;
			var producersId = model.Producers;
			var writersId = model.Writers;
			var roles = model.Roles;

			var names = await _namesService.GetAll();
			var directorsNames = names.Where(n => directorsId.Contains(n.Id));
			var producersNames = names.Where(n => producersId.Contains(n.Id));
			var writersNames = names.Where(n => writersId.Contains(n.Id));
			var rolesNames = names.Where(n => roles.Keys.Contains(n.Id));

			_moviesService.Add(movie);
			_ratingsService.Add(rating);

			foreach (var directorName in directorsNames)
			{
				_directorsService.Add(new Director { Movie = movie, Name = directorName });
			}

			foreach (var producerName in producersNames)
			{
				await _producersService.Add(new Producer { Movie = movie, Name = producerName });
			}

			foreach (var writerName in writersNames)
			{
				await _writersService.Add(new Writer { Movie = movie, Name = writerName });
			}

			foreach (var roleName in rolesNames)
			{
				
				var character = roles.FirstOrDefault(r => r.Key == roleName.Id).Value;
				await _rolesService.Add(new Role { Movie = movie, Name = roleName, Character = character });
			}

			return RedirectToAction("Index");
		}
	}
}
