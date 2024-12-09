
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
    public class AptMtmReftindaklanjutpengobatanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptMtmReftindaklanjutpengobatanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptMtmReftindaklanjutpengobatan
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptMtmReftindaklanjutpengobatans.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptMtmReftindaklanjutpengobatan/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptMtmReftindaklanjutpengobatans.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptMtmReftindaklanjutpengobatan
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptMtmReftindaklanjutpengobatan model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptMtmReftindaklanjutpengobatanId = Guid.NewGuid();
            _context.AptMtmReftindaklanjutpengobatans.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptMtmReftindaklanjutpengobatanId }, model);
        }

        // PUT: api/AptMtmReftindaklanjutpengobatan/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptMtmReftindaklanjutpengobatan model)
        {
            if (model == null || id != model.AptMtmReftindaklanjutpengobatanId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptMtmReftindaklanjutpengobatans.FindAsync(id);
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

            _context.AptMtmReftindaklanjutpengobatans.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptMtmReftindaklanjutpengobatan/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptMtmReftindaklanjutpengobatans.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptMtmReftindaklanjutpengobatans.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
