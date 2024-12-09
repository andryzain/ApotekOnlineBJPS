
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
    public class AptMtmReftargetpengobatanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptMtmReftargetpengobatanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptMtmReftargetpengobatan
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptMtmReftargetpengobatans.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptMtmReftargetpengobatan/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptMtmReftargetpengobatans.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptMtmReftargetpengobatan
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptMtmReftargetpengobatan model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptMtmReftargetpengobatanId = Guid.NewGuid();
            _context.AptMtmReftargetpengobatans.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptMtmReftargetpengobatanId }, model);
        }

        // PUT: api/AptMtmReftargetpengobatan/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptMtmReftargetpengobatan model)
        {
            if (model == null || id != model.AptMtmReftargetpengobatanId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptMtmReftargetpengobatans.FindAsync(id);
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

            _context.AptMtmReftargetpengobatans.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptMtmReftargetpengobatan/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptMtmReftargetpengobatans.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptMtmReftargetpengobatans.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
