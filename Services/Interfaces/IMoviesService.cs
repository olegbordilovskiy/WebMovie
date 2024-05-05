using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAll();
        Task<Movie> GetById(int id);
        Task Add(Movie movie);
        Task<Movie> Update(int id, Movie movie);
        Task Delete(int id);
    }
}
