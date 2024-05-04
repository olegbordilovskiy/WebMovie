using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class MoviesService : IMoviesService
	{
		private readonly DatabaseContext _databaseContext;
        public MoviesService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Add(Movie movie)
		{
			_databaseContext.Movies.Add(movie);
			//_databaseContext.SaveChanges();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Movie>> GetAll()
		{
			var result = await _databaseContext.Movies.ToListAsync();
			return result;
		}

		public Movie GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Movie Update(int id, Movie movie)
		{
			throw new NotImplementedException();
		}
	}
}
