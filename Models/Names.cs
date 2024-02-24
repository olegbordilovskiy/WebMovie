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

        // Relations
        public List<Directors> Directors { get; set; }
        public List<KnownFor> KnownFor { get; set; }
        public List<Writers> Writers { get; set; }
        public List<Roles > Roles { get; set; }
        public List<Professions> Professions { get; set; }

    }
}
