
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
    public class AptMtmRefmasalahController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptMtmRefmasalahController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptMtmRefmasalah
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptMtmRefmasalahs.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptMtmRefmasalah/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptMtmRefmasalahs.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptMtmRefmasalah
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptMtmRefmasalah model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptMtmRefmasalahId = Guid.NewGuid();
            _context.AptMtmRefmasalahs.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptMtmRefmasalahId }, model);
        }

        // PUT: api/AptMtmRefmasalah/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptMtmRefmasalah model)
        {
            if (model == null || id != model.AptMtmRefmasalahId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptMtmRefmasalahs.FindAsync(id);
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

            _context.AptMtmRefmasalahs.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptMtmRefmasalah/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptMtmRefmasalahs.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptMtmRefmasalahs.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}