using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface INamesService
	{
		Task<IEnumerable<Name>> GetAll();
		Name GetById(int id);
		void Add(Name name);
		Name Update(int id, Name name);
		void Delete(int id);

		Task<IEnumerable<Name>> GetDirectorsById(List<int> id);
	}
}
