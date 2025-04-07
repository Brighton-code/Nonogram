namespace Nonogram.Models
{
    public class GameHistory
    {
        public int Seed { get; set; }
        public int GridSize { get; set; }
        public int HintsRequested { get; set; }
        public string GameState { get; set; } = string.Empty;
        public TimeSpan GameTime { get; set; } = new TimeSpan();
        public DateTime? CompletedAt { get; set; } = null;
        public DateTime? CreatedAt { get; set; } = null;
        public DateTime? UpdatedAt { get; set; } = null;
    }
}
