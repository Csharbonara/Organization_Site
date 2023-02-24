using MainPage.Data.Enum;
using System.ComponentModel.DataAnnotations;
namespace MainPage.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public TagCategory? TagCategory { get; set; }
    }
}
