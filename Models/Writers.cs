using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
    public class Writers
    {
        public int MovieId { get; set; }
        public int NameId { get; set; }

        [ForeignKey("MovieId")]
        public Movies Movie { get; set; }

        [ForeignKey("NameId")]
        public Names Name { get; set; }
    }
}
