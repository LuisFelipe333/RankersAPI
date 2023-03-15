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
        public async Task<ActionResult<List<Ranker>>> GetRankers()
        {
            var rankers = new List<Ranker>();
            return Ok(rankers);
        }

        public RankersController(DataContext context)
        {
            this.context = context;
        }

    }
}
