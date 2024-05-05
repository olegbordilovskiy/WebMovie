using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IDirectorsService
	{
		Task<IEnumerable<Director>> GetAll();
		Director GetById(int id);
		void Add(Director director);
		Director Update(int id, Director director);
		void Delete(int id);
		Task<IEnumerable<int>> GetDirectorsForMovie(Movie movie);
	}
}
