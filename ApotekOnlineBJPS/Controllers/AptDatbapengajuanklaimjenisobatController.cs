
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
    public class AptDatbapengajuanklaimjenisobatController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptDatbapengajuanklaimjenisobatController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptDatbapengajuanklaimjenisobat
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptDatbapengajuanklaimjenisobats.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptDatbapengajuanklaimjenisobat/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptDatbapengajuanklaimjenisobats.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptDatbapengajuanklaimjenisobat
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptDatbapengajuanklaimjenisobat model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptDatbapengajuanklaimjenisobatId = Guid.NewGuid();
            _context.AptDatbapengajuanklaimjenisobats.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptDatbapengajuanklaimjenisobatId }, model);
        }

        // PUT: api/AptDatbapengajuanklaimjenisobat/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptDatbapengajuanklaimjenisobat model)
        {
            if (model == null || id != model.AptDatbapengajuanklaimjenisobatId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptDatbapengajuanklaimjenisobats.FindAsync(id);
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

            _context.AptDatbapengajuanklaimjenisobats.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptDatbapengajuanklaimjenisobat/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptDatbapengajuanklaimjenisobats.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptDatbapengajuanklaimjenisobats.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
