using WebMovie.Models;

namespace WebMovie.ViewModels.Movies
{
	public class CreateMovieVM
	{
		public Movie Movie { get; set; }
		public Rating Rating { get; set; }
		public List<int> Directors { get; set; }
		public List<int> Writers { get; set; }
		public Dictionary<int, string> Roles { get; set; }
		public List<int> Producers { get; set; }

	}
}
