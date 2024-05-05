using WebMovie.Data;
using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IProducersService
	{
		Task<IEnumerable<Producer>> GetAll();
		Task<Producer> GetById(int id);
		Task Add(Producer producer);
		Task<Producer> Update(int id, Producer producer);
		Task Delete(int id);
		Task<IEnumerable<int>> GetProducersForMovie(Movie movie);
	}
}
