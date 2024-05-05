using System.ComponentModel.DataAnnotations;
using WebMovie.Data.Enumerations;

namespace WebMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "English title")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string EnglishTitle { get; set; }

		[Display(Name = "Description")]
		[Required(ErrorMessage = "Description is required")]
		public string Description { get; set; }

        public ushort StartYear { get; set; }

        public ushort EndYear { get; set;}

        public Country Country { get; set; }
        public MPAA MPAA { get; set; }

		[Required(ErrorMessage = "Runtime is required")]
		public ushort RuntimeMinutes { get; set; }

		[Display(Name = "Poster Image URL")]
		public string PosterImageUrl { get; set; }

        public List<Director> Directors { get; set; }
        public List<KnownFor> KnownFors { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Role> Roles { get; set; }
        public List<Producer> Producers { get; set; } 
        public Rating Rating { get; set; }



    }
}
