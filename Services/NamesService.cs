using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class NamesService : INamesService
	{
		private readonly DatabaseContext _databaseContext;
        public NamesService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Add(Name name)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Name>> GetAll()
		{
			var result = await _databaseContext.Names.ToListAsync();
			return result;
		}

		public Name GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Name Update(int id, Name name)
		{
			throw new NotImplementedException();
		}
	}
}
