using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMovie.Models
{
	public class Rating
	{
		public int Id { get; set; }
		//[Key, Column(Order = 1)]
		public int MovieId { get; set; }
		//[ForeignKey("MovieId")]
		public Movie Movie { get; set; }
		public int VotesNumber { get; set; }

		[Column(TypeName = "decimal(2, 1)")]
		public decimal AverageRating { get; set; }

	}
}
