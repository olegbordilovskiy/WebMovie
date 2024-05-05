using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMovie.Data.Enumerations;

namespace WebMovie.Models
{
    public class Profession
    {
        public int Id { get; set; }
        public int NameId { get; set; }
        public Name Name { get; set; }
        public Data.Enumerations.Professions MovieProfession { get; set; }

    }
}
