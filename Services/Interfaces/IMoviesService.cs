using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        Movie Update(int id, Movie movie);
        void Delete(int id);
    }
}
