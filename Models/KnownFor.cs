using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
    public class KnownFor
    {
        public int MovieId { get; set; }
        public int NameId { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [ForeignKey("NameId")]
        public Name Name { get; set; }
    }
}
