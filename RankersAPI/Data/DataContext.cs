using Microsoft.EntityFrameworkCore;
using RankersAPI.Models;

namespace RankersAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Ranker> Rankers { get; set; }

    }
}
