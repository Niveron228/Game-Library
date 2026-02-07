using GameLibrary.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        }

        [HttpGet]
        public async Task<ActionResult<List<Game>>> GetAllGames()
        {
            return Ok(await _context.Games.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(int id)
        {
            var  game = await _context.Games.FindAsync(id);

            if (game == null)
                return NotFound("Game not found");

            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<List<Game>>> AddGame(Game newGame)
        {
            _context.Games.Add(newGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGame), new { id = newGame.Id }, newGame);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGame(int id, Game updatedGame)
        {
            var game = await _context.Games.FindAsync(id);
            if(game == null)
            {
                return NotFound("Game not found in database");
            }
            game.Title = updatedGame.Title;
            game.Genre = updatedGame.Genre;
            game.Status = updatedGame.Status;
            game.Rating = updatedGame.Rating;
            game.Platform = updatedGame.Platform;
            game.Comment = updatedGame.Comment;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        { 
            var game = await (_context.Games.FindAsync(id));
            if (game == null)
                return NotFound("Not found");

            _context.Games.Remove(game);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

