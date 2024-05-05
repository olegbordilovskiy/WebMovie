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
			_databaseContext.Names.Add(name);
			_databaseContext.SaveChanges();
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
		public async Task<IEnumerable<Name>> GetDirectorsById(List<int> id)
		{
			var directorsNames = new List<Name>();
			foreach (var directorId in id)
			{
				var name = _databaseContext.Names.Find(directorId);
				directorsNames.Add(name);
			}
			return directorsNames;
		}
	}
}
