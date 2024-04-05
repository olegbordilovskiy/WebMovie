using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class RolesService : IRolesService
	{
		private readonly DatabaseContext _databaseContext;
        public RolesService(DatabaseContext databaseContext)
        {
			_databaseContext = databaseContext;
        }
        public void Add(Role role)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Role>> GetAll()
		{
			var result = await _databaseContext.Roles.ToListAsync();
			return result;
		}

		public Role GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Role Update(int id, Role role)
		{
			throw new NotImplementedException();
		}
	}
}
