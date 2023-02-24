using System.ComponentModel.DataAnnotations;


namespace MainPage.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string RepositoryLink { get; set; }
        public string RepositoryName { get; set; }
        public string YoutubeLink { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
