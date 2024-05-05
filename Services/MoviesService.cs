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
        public async Task Add(Movie movie)
		{
			await _databaseContext.Movies.AddAsync(movie);
			await _databaseContext.SaveChangesAsync();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Movie>> GetAll()
		{
			var result = await _databaseContext.Movies.ToListAsync();
			return result;
		}

		public async Task<Movie> GetById(int id)
		{
			var movie = await _databaseContext.Movies.FindAsync(id);
			return movie;
		}

		public async Task<Movie> Update(int id, Movie movie)
		{
			throw new NotImplementedException();
		}
	}
}
