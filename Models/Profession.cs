using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMovie.Data.Enumerations;

namespace WebMovie.Models
{
    public class Profession
    {
        //[Key, Column(Order = 1)]
        public int Id { get; set; }

        //[ForeignKey("NameId")]
        public Name Name { get; set; }

        //[Key, Column(Order = 2)]
        public Data.Enumerations.Professions MovieProfession { get; set; }

    }
}
