using Microsoft.AspNetCore.Mvc;
using TogetherGame.Domain.Entities;
using TogetherGame.Persistence;
using Microsoft.AspNetCore.Authorization;

namespace TogetherGame.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        public readonly TogetherGameContext _context;

        public GameController(TogetherGameContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPost]
        public IActionResult CriarGame(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return Ok(game);
        }
        
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult BuscarGame(int id)
        {
            var game = _context.Games.Find(id);
            return Ok(game);
        }
    }
}