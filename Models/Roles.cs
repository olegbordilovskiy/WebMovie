using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
    public class Roles
    {
        public int MovieId { get; set; }
        public int NameId { get; set; }
        public string Role { get; set; }

        [ForeignKey("MovieId")]
        public Movies Movie { get; set; }

        [ForeignKey("NameId")]
        public Names Name { get; set; }

    }
}
