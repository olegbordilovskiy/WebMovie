using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
    public class Producers
    {
        public int MovieId { get; set; }
        public int NameId { get; set; }

        [ForeignKey("MovieId")]
        public Movies Movie { get; set; }

        [ForeignKey("NameId")]
        public Names Name { get; set; }
    }
}
