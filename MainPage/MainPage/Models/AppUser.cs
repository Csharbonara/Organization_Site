using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MainPage.Models
{
    public class AppUser : IdentityUser
    {
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string GithubLink { get; set; }
        public string LinkedinLink { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
