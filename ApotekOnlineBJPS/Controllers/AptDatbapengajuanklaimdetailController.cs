
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
    public class AptDatbapengajuanklaimdetailController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AptDatbapengajuanklaimdetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AptDatbapengajuanklaimdetail
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records = await _context.AptDatbapengajuanklaimdetails.ToListAsync();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptDatbapengajuanklaimdetail/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.AptDatbapengajuanklaimdetails.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptDatbapengajuanklaimdetail
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AptDatbapengajuanklaimdetail model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.AptDatbapengajuanklaimdetailId = Guid.NewGuid();
            _context.AptDatbapengajuanklaimdetails.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.AptDatbapengajuanklaimdetailId }, model);
        }

        // PUT: api/AptDatbapengajuanklaimdetail/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AptDatbapengajuanklaimdetail model)
        {
            if (model == null || id != model.AptDatbapengajuanklaimdetailId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.AptDatbapengajuanklaimdetails.FindAsync(id);
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

            _context.AptDatbapengajuanklaimdetails.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptDatbapengajuanklaimdetail/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.AptDatbapengajuanklaimdetails.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.AptDatbapengajuanklaimdetails.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
