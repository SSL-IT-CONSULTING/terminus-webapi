using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using terminus_webapi.Data;
using terminus_webapi.Entities;
using terminus_webapi.ViewModels;

namespace terminus_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenuesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public RevenuesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Revenues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VMRevenue>>> GetRevenues()
        {
            //return await _context.Revenues.ToListAsync();
            return new List<VMRevenue> { new VMRevenue() { revenueCode = "test" } };
        }

        // GET: api/Revenues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Revenue>> GetRevenue(int id)
        {
            var revenue = await _context.Revenues.FindAsync(id);

            if (revenue == null)
            {
                return NotFound();
            }

            return revenue;
        }

        // PUT: api/Revenues/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRevenue(int id, Revenue revenue)
        {
            if (id != revenue.revenuesID)
            {
                return BadRequest();
            }

            _context.Entry(revenue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RevenueExists(id))
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

        // POST: api/Revenues
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Revenue>> PostRevenue(Revenue revenue)
        {
            _context.Revenues.Add(revenue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRevenue", new { id = revenue.revenuesID }, revenue);
        }

        // DELETE: api/Revenues/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Revenue>> DeleteRevenue(int id)
        {
            var revenue = await _context.Revenues.FindAsync(id);
            if (revenue == null)
            {
                return NotFound();
            }

            _context.Revenues.Remove(revenue);
            await _context.SaveChangesAsync();

            return revenue;
        }

        private bool RevenueExists(int id)
        {
            return _context.Revenues.Any(e => e.revenuesID == id);
        }
    }
}
