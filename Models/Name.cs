using System.ComponentModel.DataAnnotations;

namespace WebMovie.Models
{
    public class Name
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ushort BirthYear { get; set; }
        public ushort? DeathYear { get; set; }
        public string Description { get; set; }
        public string FaceImageUrl { get; set; }

		public List<Director> Directors { get; set; }
        public List<KnownFor> KnownFors { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Role > Roles { get; set; }
        public List<Profession> Professions { get; set; }
        public List<Producer> Producers { get; set; }

    }
}
