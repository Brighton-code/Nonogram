namespace Nonogram.Models
{
    public class GameHistory
    {
        public int Seed { get; set; }
        public int GridSize { get; set; }
        public string GameState { get; set; } = string.Empty;
        public TimeSpan GameTime { get; set; } = new TimeSpan();
        public DateTime? CompletedAt { get; set; } = null;
        public DateTime? CreatedAt { get; set; } = null;
        public DateTime? UpdatedAt { get; set; } = null;
        // Add function to all properties that when their value changes UpdatedAt changes too
        //public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
