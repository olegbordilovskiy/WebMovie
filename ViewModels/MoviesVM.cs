using WebMovie.Models;

namespace WebMovie.ViewModels
{
	public class MoviesVM
	{
		//public IEnumerable<Movie> Movies { get; set; }
		//public IEnumerable<Rating> Ratings { get; set; }
		//public IEnumerable<Director> Directors { get; set; }
		//public IEnumerable<KnownFor> KnownFors { get; set; }
		//public IEnumerable<Writer> Writers { get; set; }
		//public IEnumerable<Role> Roles { get; set; }
		//public IEnumerable<Producer> Producers { get; set; }
		public Movie Movie { get; set; }
		public Rating Rating { get; set; }
		public IEnumerable<string> Directors { get; set; }
		//public IEnumerable<Director> Directors { get; set; }
		//public IEnumerable<Writer> Writers { get; set; }
		//public IEnumerable<Role> Roles { get; set; }
		//public IEnumerable<Producer> Producers { get; set; }
	}
}
