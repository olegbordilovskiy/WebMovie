using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class DirectorsService : IDirectorsService
	{
		private readonly DatabaseContext _databaseContext;
		public DirectorsService(DatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}
		public void Add(Director director)
		{
			_databaseContext.Directors.Add(director);
			_databaseContext.SaveChanges();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Director>> GetAll()
		{
			var result = await _databaseContext.Directors.ToListAsync();
			return result;
		}

		public Director GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Director Update(int id, Director director)
		{
			throw new NotImplementedException();
		}
		public async Task <IEnumerable<int>> GetDirectorsForMovie(Movie movie)
		{
			var directors = await _databaseContext.Directors
				.Where(d => d.Movie == movie)
				 .Select(d => d.NameId)
				.ToListAsync();

			return directors;
		}
	}
}
