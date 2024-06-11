using _080_CSharp_CQRS_MediatorR.Data;
using _080_CSharp_CQRS_MediatorR.Models;
using Microsoft.AspNetCore.Mvc;

namespace _080_CSharp_CQRS_MediatorR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        private readonly _080_CSharp_CQRS_MediatorRDBContext _context;

        public PlayersController(_080_CSharp_CQRS_MediatorRDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreatePlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return Ok(player.Id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayerById(int id)
        {
            var player = await _context.Players.FindAsync(id);

            return Ok(player);
        }
    }
}
