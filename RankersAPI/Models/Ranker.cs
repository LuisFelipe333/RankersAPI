﻿namespace RankersAPI.Models
{
    public class Ranker
    {
        public int rank {  get; set; }
        public string name { get; set; }
        public string sobriquet { get; set; }
        public Positions position { get; set; }
        public string description { get; set; }
    }
}
