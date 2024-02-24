using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
    public class Role
    {
        [Key, Column(Order = 1)]
        public int MovieId { get; set; }

        [Key, Column(Order = 2)]
        public int NameId { get; set; }
        public string Character { get; set; }

        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [ForeignKey("NameId")]
        public Name Name { get; set; }

    }
}
