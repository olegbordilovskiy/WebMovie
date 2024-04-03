using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
	[PrimaryKey(nameof(MovieId), nameof(NameId))]
	public class Writer
    {
       //public int Id { get; set; }
        [Column(Order = 1)]
        public int MovieId { get; set; }

        [Column(Order = 2)]
        public int NameId { get; set; }

        //[ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        //[ForeignKey("NameId")]
        public Name Name { get; set; }
    }
}
