using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UpmeetAPI.DbModels;

namespace UpmeetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritedEventsController : ControllerBase
    {
        private readonly UpmeetDbContext _context;

        public FavoritedEventsController(UpmeetDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoritedEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoritedEvent>>> GetFavoritedEvents()
        {
            return await _context.FavoritedEvents.ToListAsync();
        }

        // GET: api/FavoritedEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FavoritedEvent>> GetFavoritedEvent(int id)
        {
            var favoritedEvent = await _context.FavoritedEvents.FindAsync(id);

            if (favoritedEvent == null)
            {
                return NotFound();
            }

            return favoritedEvent;
        }

        // PUT: api/FavoritedEvents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoritedEvent(int id, FavoritedEvent favoritedEvent)
        {
            if (id != favoritedEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoritedEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoritedEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FavoritedEvents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FavoritedEvent>> PostFavoritedEvent(FavoritedEvent favoritedEvent)
        {
            _context.FavoritedEvents.Add(favoritedEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFavoritedEvent", new { id = favoritedEvent.Id }, favoritedEvent);
        }

        // DELETE: api/FavoritedEvents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoritedEvent(int id)
        {
            var favoritedEvent = await _context.FavoritedEvents.FindAsync(id);
            if (favoritedEvent == null)
            {
                return NotFound();
            }

            _context.FavoritedEvents.Remove(favoritedEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FavoritedEventExists(int id)
        {
            return _context.FavoritedEvents.Any(e => e.Id == id);
        }
    }
}
