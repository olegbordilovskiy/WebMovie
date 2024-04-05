using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IRolesService
	{
		Task<IEnumerable<Role>> GetAll();
		Role GetById(int id);
		void Add(Role role);
		Role Update(int id, Role role);
		void Delete(int id);
	}
}
