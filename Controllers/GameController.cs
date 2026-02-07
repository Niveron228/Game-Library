using GameLibrary.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GameLibrary.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GamesController(AppDbContext context)
        {
            _context = context;
            if (!_context.Games.Any())
            {
                _context.Games.Add(new Game { Title = "Stalker 2", Genre = "Shooter", Status = "Waiting", Rating = 7, Platform = "PC", Comment = "Good Game" });
                _context.Games.Add(new Game { Title = "Minecraft", Genre = "Sandbox", Status = "Playing", Rating = 9, Platform = "xBox", Comment = "My the best game" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Game>> GetAllGames()
        {
            return Ok(_context.Games.ToList());
        }
        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(int id)
        {
            var game = _context.Games.Find(id);

            if (game == null)
                return NotFound("Game not found");

            return Ok(game);
        }

        [HttpPost]
        public ActionResult<List<Game>> AddGame(Game newGame)
        {
            _context.Games.Add(newGame);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetGame), new { id = newGame.Id }, newGame);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateGame(int id, Game updatedGame)
        {
            var game = _context.Games.Find(id);
            if(game == null)
            {
                return NotFound("Game not found in database");
            }
            game.Title = updatedGame.Title;
            game.Genre = updatedGame.Genre;
            game.Status = updatedGame.Status;
            game.Rating = updatedGame.Rating;
            game.Comment = updatedGame.Comment;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGame(int id)
        { 
            var game = (_context.Games.Find(id));
            if (game == null)
                return NotFound("Not found");

            _context.Games.Remove(game);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

