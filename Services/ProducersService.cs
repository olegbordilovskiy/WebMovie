using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class ProducersService : IProducersService
	{
		private readonly DatabaseContext _databaseContext;
        public ProducersService(DatabaseContext databaseContext)
        {
			_databaseContext = databaseContext;            
        }
        public async Task Add(Producer producer)
		{
			await _databaseContext.Producers.AddAsync(producer);
			await _databaseContext.SaveChangesAsync();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Producer>> GetAll()
		{
			var producers = await _databaseContext.Producers.ToListAsync();
			return producers;
		}

		public Task<Producer> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Producer> Update(int id, Producer producer)
		{
			throw new NotImplementedException();
		}
	}
}
