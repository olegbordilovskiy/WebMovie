using Microsoft.AspNetCore.Mvc;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services;
using WebMovie.Services.Interfaces;
using WebMovie.ViewModels.Movies;
using WebMovie.ViewModels.Names;

namespace WebMovie.Controllers
{
	public class NamesController : Controller
	{
		private readonly DatabaseContext _databaseContext;
		private readonly IMoviesService _moviesService;
		private readonly INamesService _namesService;
		private readonly IProfessionsService _professionsService;

		public NamesController(IMoviesService moviesService, INamesService namesService, IProfessionsService professionsService)
		{
			_moviesService = moviesService;
			_namesService = namesService;
			_professionsService = professionsService;
		}
		public async Task<IActionResult> Index()
		{
			//var movies = await _moviesService.GetAll();
			var names = await _namesService.GetAll();
			var professions = await _professionsService.GetAll();

			var namesVM = new List<NamesVM>();

			foreach (var name in names)
			{
				var nameProfessions = professions.Where(p => p.Name == name).Select(n => n.MovieProfession).ToList();

				namesVM.Add(new NamesVM
				{
					Name = name,
					Professions = nameProfessions
				}
				);
			}

			return View(namesVM);
		}

		public async Task<IActionResult> Create()
		{
			var names = await _namesService.GetAll();
			//var createNameMV = new CreateNameVM();

			ViewBag.Names = names;

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateNameVM model)
		{
			var name = model.Name;
			var professions = model.Professions;

			_namesService.Add(name);
			foreach (var profession in professions)
			{
				var prof = new Profession { Name = name, MovieProfession = profession };
				await _professionsService.Add(prof);
			}
			

			return RedirectToAction("Index");
		}
		
	}
}
