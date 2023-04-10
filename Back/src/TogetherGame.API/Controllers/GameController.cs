using Microsoft.AspNetCore.Mvc;
using TogetherGame.Domain.Entities;
using TogetherGame.Persistence;
using Microsoft.AspNetCore.Authorization;

namespace TogetherGame.API.Controllers
{
[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        public readonly TogetherGameContext _context;

        public GameController(TogetherGameContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public IActionResult CriarGame(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return Ok(game);

        }


    }
}