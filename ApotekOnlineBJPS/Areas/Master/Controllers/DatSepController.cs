using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using ApotekOnlineBJPS.Areas.Master.Models;

namespace ApotekOnlineBJPS.Areas.Master.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Endpoint ini memerlukan token
    [EnableCors("AllowSpecific")]
    public class DatSepController : Controller
    {

        private readonly ApplicationDbContext _context;

            public DatSepController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: api/DatSep
            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var records = await _context.DatSeps.ToListAsync();
                if (records == null || !records.Any())
                {
                    return NotFound(new { message = "Tidak ada data ditemukan." });
                }
                return Ok(new { message = "Data ditemukan.", data = records });
            }

            // GET: api/DatSep/{id}
            [HttpGet("{id}")]
            public async Task<IActionResult> GetById(Guid id)
            {
                var record = await _context.DatSeps.FindAsync(id);
                if (record == null)
                {
                    return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
                }
                return Ok(new { message = "Data ditemukan.", data = record });
            }

            // POST: api/DatSep
            [HttpPost]
            public async Task<IActionResult> Create([FromBody] DatSep model)
            {
                if (model == null)
                {
                    return BadRequest(new { message = "Data tidak valid." });
                }
                model.DatSepId = Guid.NewGuid();
                _context.DatSeps.Add(model);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetById), new { id = model.DatSepId }, model);
            }

            // PUT: api/DatSep/{id}
            [HttpPut("{id}")]
            public async Task<IActionResult> Update(Guid id, [FromBody] DatSep model)
            {
                if (model == null || id != model.DatSepId)
                {
                    return BadRequest(new { message = "Data tidak valid." });
                }
                var existingRecord = await _context.DatSeps.FindAsync(id);
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

                _context.DatSeps.Update(existingRecord);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Data berhasil diperbarui." });
            }

            // DELETE: api/DatSep/{id}
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(Guid id)
            {
                var record = await _context.DatSeps.FindAsync(id);
                if (record == null)
                {
                    return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
                }
                _context.DatSeps.Remove(record);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Data berhasil dihapus." });
            }
        }
    
}
