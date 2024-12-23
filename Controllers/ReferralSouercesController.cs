using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConfreneceAttendees.Data;

namespace ConfreneceAttendees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferralSouercesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReferralSouercesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ReferralSouerces
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReferralSouerce>>> GetReferralSouerce()
        {
            return await _context.ReferralSouerce.ToListAsync();
        }

        // GET: api/ReferralSouerces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReferralSouerce>> GetReferralSouerce(int id)
        {
            var referralSouerce = await _context.ReferralSouerce.FindAsync(id);

            if (referralSouerce == null)
            {
                return NotFound();
            }

            return referralSouerce;
        }

        // PUT: api/ReferralSouerces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReferralSouerce(int id, ReferralSouerce referralSouerce)
        {
            if (id != referralSouerce.Id)
            {
                return BadRequest();
            }

            _context.Entry(referralSouerce).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReferralSouerceExists(id))
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

        // POST: api/ReferralSouerces
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ReferralSouerce>> PostReferralSouerce(ReferralSouerce referralSouerce)
        {
            _context.ReferralSouerce.Add(referralSouerce);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReferralSouerce", new { id = referralSouerce.Id }, referralSouerce);
        }

        // DELETE: api/ReferralSouerces/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReferralSouerce(int id)
        {
            var referralSouerce = await _context.ReferralSouerce.FindAsync(id);
            if (referralSouerce == null)
            {
                return NotFound();
            }

            _context.ReferralSouerce.Remove(referralSouerce);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReferralSouerceExists(int id)
        {
            return _context.ReferralSouerce.Any(e => e.Id == id);
        }
    }
}
