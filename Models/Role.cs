using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMovie.Models
{
	[PrimaryKey(nameof(MovieId), nameof(NameId))]
	public class Role
    {
        public int MovieId { get; set; }
        public int NameId { get; set; }
        public string Character { get; set; }
        public Movie Movie { get; set; }
        public Name Name { get; set; }

    }
}
