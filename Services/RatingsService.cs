using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class RatingsService : IRatingsService
	{
		private readonly DatabaseContext _databaseContext;
		public RatingsService(DatabaseContext databaseContext) 
		{
			_databaseContext = databaseContext;
		}
		public void Add(Rating rating)
		{
			//rating.Id = null;
			_databaseContext.Ratings.Add(rating);
			_databaseContext.SaveChanges();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Rating>> GetAll()
		{
			var result = await _databaseContext.Ratings.ToListAsync();
			return result;
		}

		public Rating GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Rating Update(int id, Rating rating)
		{
			throw new NotImplementedException();
		}
	}
}
