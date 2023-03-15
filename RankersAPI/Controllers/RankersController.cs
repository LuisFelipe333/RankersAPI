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

        public RankersController(DataContext context)
        {
            this.context = context;
        }

    }
}
