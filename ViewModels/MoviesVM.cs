using WebMovie.Models;

namespace WebMovie.ViewModels
{
	public class MoviesVM
	{
		public IEnumerable<Movie> Movies { get; set; }
		public IEnumerable<Rating> Ratings { get; set; }
	}
}
