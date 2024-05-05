using WebMovie.Models;

namespace WebMovie.Services.Interfaces
{
	public interface IProfessionsService
	{
		Task<IEnumerable<Profession>> GetAll();
		Task<Profession> GetById(int id);
		Task Add(Profession profession);
		Task<Profession> Update(int id, Profession profession);
		Task Delete(int id);
	}
}
