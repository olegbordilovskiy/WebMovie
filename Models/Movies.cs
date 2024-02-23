using System.ComponentModel.DataAnnotations;
using WebMovie.Data.Enumerations;

namespace WebMovie.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string EnglishTitle { get; set; }
        public string Description { get; set; }
        public DateOnly StartYear { get; set; }
        public DateOnly EndYear { get; set;}
        public Country Country { get; set; }
        public ushort RuntimeMinutes { get; set; }


        

    }
}
