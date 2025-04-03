﻿namespace Nonogram.Models
{
    public class GameHistory
    {
        public int Seed { get; set; }
        public string GameState { get; set; } = string.Empty;

        public DateTime? CompletedAt { get; set; } = null;
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        // Add function to all properties that when their value changes UpdatedAt changes too
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
