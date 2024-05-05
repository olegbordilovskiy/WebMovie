using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
	[PrimaryKey(nameof(MovieId), nameof(NameId))]
	public class Director
    {
        public int MovieId { get; set; }
        public int NameId { get; set; }
        public Movie Movie { get; set; }
        public Name Name { get; set; }
    }
}
