using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IRatingsService
	{
		Task<IEnumerable<Rating>> GetAll();
		Rating GetById(int id);
		void Add(Rating rating);
		Rating Update(int id, Rating rating);
		void Delete(int id);
	}
}
