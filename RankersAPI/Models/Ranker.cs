using RankersAPI.Models.Enums;

namespace RankersAPI.Models
{
    public class Ranker
    {
        public int Id { get; set; }
        public string? rank {  get; set; } = string.Empty;
        public Status status { get; set; }
        public string name { get; set; } 
        public string? sobriquet { get; set; } = string.Empty;
        public Positions positions { get; set; }
        public Positions? secondaryPosition { get; set; } = null;
        public string description { get; set; }
    }
}
