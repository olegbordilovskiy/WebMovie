using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IRolesService
	{
		Task<IEnumerable<Role>> GetAll();
		Task<Role> GetById(int id);
		Task Add(Role role);
		Task<Role> Update(int id, Role role);
		Task Delete(int id);
	}
}
