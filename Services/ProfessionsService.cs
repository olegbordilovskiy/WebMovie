using Microsoft.EntityFrameworkCore;
using WebMovie.Data;
using WebMovie.Models;
using WebMovie.Services.Interfaces;

namespace WebMovie.Services
{
	public class ProfessionsService : IProfessionsService
	{
		private readonly DatabaseContext _databaseContext;
        public ProfessionsService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task Add(Profession profession)
		{
			await _databaseContext.Professions.AddAsync(profession);
			await _databaseContext.SaveChangesAsync();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Profession>> GetAll()
		{
			var professions = await _databaseContext.Professions.ToListAsync();
			return professions;
		}

		public Task<Profession> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<Profession> Update(int id, Profession profession)
		{
			throw new NotImplementedException();
		}
	}
}
