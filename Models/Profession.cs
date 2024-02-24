using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebMovie.Data.Enumerations;

namespace WebMovie.Models
{
    public class Profession
    {
        [Key]
        public int NameId { get; set; }

        [ForeignKey("NameId")]
        public Name Name { get; set; }
        public Profession MovieProfession { get; set; }

    }
}
