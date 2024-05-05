using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface INamesService
	{
		Task<IEnumerable<Name>> GetAll();
		Task<Name> GetById(int id);
		void Add(Name name);
		Name Update(int id, Name name);
		void Delete(int id);
		Task<IEnumerable<Name>> GetDirectorsById(List<int> id);
		Task<IEnumerable<Name>> GetProducersById(List<int> id);
		Task<IEnumerable<Name>> GetWritersById(List<int> id);
	}
}
