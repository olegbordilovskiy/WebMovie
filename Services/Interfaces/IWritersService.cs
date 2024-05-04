using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IWritersService
	{
		Task<IEnumerable<Writer>> GetAll();
		Task<Writer> GetById(int id);
		Task Add(Writer writer);
		Task<Writer> Update(int id, Writer writer);
		Task Delete(int id);
	}
}
