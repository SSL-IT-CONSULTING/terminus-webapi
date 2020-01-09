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
    public class TenantPropertiesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public TenantPropertiesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/TenantProperties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VMTenantProperty>>> GetTenantProperty()
        {
            //return await _context.TenantProperty.ToListAsync();
            return new List<VMTenantProperty> { new VMTenantProperty() { tenantPropertyCode = "test" } };
        }

        // GET: api/TenantProperties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TenantProperty>> GetTenantProperty(int id)
        {
            var tenantProperty = await _context.TenantProperty.FindAsync(id);

            if (tenantProperty == null)
            {
                return NotFound();
            }

            return tenantProperty;
        }

        // PUT: api/TenantProperties/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTenantProperty(int id, TenantProperty tenantProperty)
        {
            if (id != tenantProperty.tenantPropertyID)
            {
                return BadRequest();
            }

            _context.Entry(tenantProperty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TenantPropertyExists(id))
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

        // POST: api/TenantProperties
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TenantProperty>> PostTenantProperty(TenantProperty tenantProperty)
        {
            _context.TenantProperty.Add(tenantProperty);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTenantProperty", new { id = tenantProperty.tenantPropertyID }, tenantProperty);
        }

        // DELETE: api/TenantProperties/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TenantProperty>> DeleteTenantProperty(int id)
        {
            var tenantProperty = await _context.TenantProperty.FindAsync(id);
            if (tenantProperty == null)
            {
                return NotFound();
            }

            _context.TenantProperty.Remove(tenantProperty);
            await _context.SaveChangesAsync();

            return tenantProperty;
        }

        private bool TenantPropertyExists(int id)
        {
            return _context.TenantProperty.Any(e => e.tenantPropertyID == id);
        }
    }
}
