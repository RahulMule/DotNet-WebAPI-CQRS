using System.ComponentModel.DataAnnotations;

namespace DotNet_WebAPI_CQRS.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Price { get; set; }
    }
}
