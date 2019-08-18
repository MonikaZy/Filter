using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Filter.Domain.Models;
using Filter.Domain;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : Controller
    {
        private readonly FilterContext _context;

        public FilterController(FilterContext _context) {
            this._context = _context;

            if (_context.FilterItems.Count() == 0) {
                _context.FilterItems.Add(new FilterItem { Name = "fItem1" });
                _context.SaveChanges();
            }
        }
        
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilterItem>>> GetFilterItem()
        {
         
            return await _context.FilterItems.ToListAsync();
        }

   

    // GET api/values/5
    [HttpGet("{id}")]
        public async Task<ActionResult<FilterItem>> GetFilterItem(long id)
        {
            var filterItem = await _context.FilterItems.FindAsync(id);
            if (filterItem == null) {
                return NotFound();
            }

            return filterItem;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<FilterItem>> PostFilterItem(FilterItem item)
        {
            _context.FilterItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFilterItem), new { id = item.Id }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult>  PutFilterItem(long id, FilterItem item)
        {
            if (id != item.Id) {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilterItem(long id)
        {
            var filterItem = await _context.FilterItems.FindAsync(id);

            if (filterItem == null)
            {
                return NotFound();
            }

            _context.FilterItems.Remove(filterItem);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
