using RankersAPI.Models.Enums;

namespace RankersAPI.Models
{
    public class Ranker
    {
        public int Id { get; set; }
        public int rank {  get; set; }
        public string name { get; set; } 
        public string sobriquet { get; set; }
        public Positions positions { get; set; }
        public Positions secondaryPosition { get; set; }
        public string description { get; set; }
    }
}
