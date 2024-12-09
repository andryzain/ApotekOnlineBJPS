
using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ApotekOnlineBJPS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AptHistupdDatresepController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptHistupdDatresepController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptHistupdDatresep
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptHistupdDatreseps.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptHistupdDatresep/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptHistupdDatreseps.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptHistupdDatresep
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptHistupdDatresep model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptHistupdDatresepId = Guid.NewGuid();
            _context.AptHistupdDatreseps.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptHistupdDatresepId }, model);
        }

        // PUT: api/AptHistupdDatresep/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptHistupdDatresep model)
        {
            if (model == null || id != model.AptHistupdDatresepId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptHistupdDatreseps.FindAsync(id);
            if (existingRecord == null)
            {
                return NotFound(new { message = "Data tidak ditemukan." });
            }
            // Update properties
            foreach (var prop in model.GetType().GetProperties())
            {
                var value = prop.GetValue(model);
                if (value != null)
                {
                    prop.SetValue(existingRecord, value);
                }
            }

            _context.AptHistupdDatreseps.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptHistupdDatresep/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptHistupdDatreseps.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptHistupdDatreseps.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
