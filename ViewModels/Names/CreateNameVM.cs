using WebMovie.Data.Enumerations;
using WebMovie.Models;

namespace WebMovie.ViewModels.Names
{
	public class CreateNameVM
	{
		public Name Name { get; set; }
		public List<Professions> Professions { get; set; }
	}
}
