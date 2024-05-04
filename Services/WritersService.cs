using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class WritersService : IWritersService
	{
		private readonly DatabaseContext _databaseContext;
        public WritersService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task Add(Writer writer)
		{
			await _databaseContext.Writers.AddAsync(writer);
			await _databaseContext.SaveChangesAsync();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Writer>> GetAll()
		{
			var writers = await _databaseContext.Writers.ToListAsync();
			return writers;
		}

		public Task<Writer> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Writer> Update(int id, Writer writer)
		{
			throw new NotImplementedException();
		}
	}
}
