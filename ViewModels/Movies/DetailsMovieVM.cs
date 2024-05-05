using WebMovie.Models;

namespace WebMovie.ViewModels.Movies
{
	public class DetailsMovieVM
	{
		public Movie Movie { get; set; }
		public Rating Rating { get; set; }
		public Dictionary<int, string> Directors { get; set; }
		public Dictionary<int,string> Producers { get; set; }
		public Dictionary<int, string> Writers { get; set; }

	}
}
