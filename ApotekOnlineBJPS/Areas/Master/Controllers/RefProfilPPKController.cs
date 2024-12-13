using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApotekOnlineBJPS.Areas.Master.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Endpoint ini memerlukan token
    [EnableCors("AllowSpecific")]
    public class RefProfilPPKController : Controller
    {

        private readonly ApplicationDbContext _context;

        public RefProfilPPKController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RefProfilPPK
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var records =  _context.RefProfilPPKs.ToList();
            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/RefProfilPPK/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var record = await _context.RefProfilPPKs.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/RefProfilPPK
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RefProfilPPK model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            model.RefProfilPPKId = Guid.NewGuid();
            _context.RefProfilPPKs.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = model.RefProfilPPKId }, model);
        }

        // PUT: api/RefProfilPPK/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] RefProfilPPK model)
        {
            if (model == null || id != model.RefProfilPPKId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }
            var existingRecord = await _context.RefProfilPPKs.FindAsync(id);
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

            _context.RefProfilPPKs.Update(existingRecord);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/RefProfilPPK/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var record = await _context.RefProfilPPKs.FindAsync(id);
            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }
            _context.RefProfilPPKs.Remove(record);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Data berhasil dihapus." });
        }
    }
}
