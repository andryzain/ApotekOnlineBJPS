
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
    public class AptDatnofpkHistController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptDatnofpkHistController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptDatnofpkHist
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptDatnofpkHists.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptDatnofpkHist/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptDatnofpkHists.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptDatnofpkHist
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptDatnofpkHist model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptDatnofpkHistId = Guid.NewGuid();
            _context.AptDatnofpkHists.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptDatnofpkHistId }, model);
        }

        // PUT: api/AptDatnofpkHist/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptDatnofpkHist model)
        {
            if (model == null || id != model.AptDatnofpkHistId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptDatnofpkHists.FindAsync(id);
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

            _context.AptDatnofpkHists.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptDatnofpkHist/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptDatnofpkHists.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptDatnofpkHists.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
