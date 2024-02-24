using System.ComponentModel.DataAnnotations;

namespace WebMovie.Models
{
    public class Name
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthYear { get; set; }
        public DateOnly? DeathYear { get; set; }
        public string Description { get; set; }

        // Relations
        public List<Director> Directors { get; set; }
        public List<KnownFor> KnownFor { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Role > Roles { get; set; }
        public List<Profession> Professions { get; set; }

    }
}
