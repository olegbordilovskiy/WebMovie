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

        // Relations

        public List<Directors> Directors { get; set; }
        public List<KnownFor> KnownFor { get; set; }
        public List<Writers> Writers { get; set; }
        public List<Roles> Roles { get; set; }



    }
}
