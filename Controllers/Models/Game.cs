using System.ComponentModel.DataAnnotations;

namespace GameLibrary.Controllers.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Genre { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string Platform { get; set; } = string.Empty; 
        public string Status { get; set; } = "Backlog";
        [Range(0,10)]
        public double Rating { get; set; }
        [Required]
        [MaxLength(500)]
        public string Comment {  get; set; } = string.Empty;
    }
}
