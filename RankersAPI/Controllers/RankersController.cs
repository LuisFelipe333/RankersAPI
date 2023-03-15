using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RankersAPI.Models;

namespace RankersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankersController : ControllerBase
    {
        private readonly DataContext context;

        public RankersController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ranker>>> GetListRankers()
        {
            return Ok(await context.Rankers.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ranker>> GetRankerById(int id)
        {
            var ranker = await context.Rankers.FindAsync(id);
            if(ranker == null)
                return BadRequest("Ranker not found");
            return Ok(ranker);
        }

        [HttpPost]
        public async Task<ActionResult<List<Ranker>>> AddRanker(Ranker ranker)
        {
            context.Rankers.Add(ranker);
            await context.SaveChangesAsync();

            return Ok(await context.Rankers.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Ranker>>> UpdateRanker(Ranker ranker)
        {
            Ranker dbRanker = await context.Rankers.FindAsync(ranker.Id);
            if (dbRanker == null)
                return BadRequest("Ranker not found");

            dbRanker.rank = ranker.rank;
            dbRanker.status = ranker.status;
            dbRanker.name = ranker.name;
            dbRanker.sobriquet = ranker.sobriquet;
            dbRanker.positions = ranker.positions;
            dbRanker.secondaryPosition = ranker.secondaryPosition;
            dbRanker.description = ranker.description;


            await context.SaveChangesAsync();


            return Ok(await context.Rankers.ToListAsync());
        }

        

    }
}
