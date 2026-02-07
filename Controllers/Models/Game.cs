namespace GameLibrary.Controllers.Models
{
    public class Game
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty; 
        public string Genre { get; set; } = string.Empty; 
        public string Platform { get; set; } = string.Empty; 
        public string Status { get; set; } = "Backlog"; 
        public double Rating { get; set; }
        public string Comment {  get; set; } = string.Empty;
    }
}
