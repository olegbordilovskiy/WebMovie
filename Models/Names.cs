using System.ComponentModel.DataAnnotations;

namespace WebMovie.Models
{
    public class Names
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthYear { get; set; }
        public DateOnly? DeathYear { get; set; }

        public string Description { get; set; }



    }
}
