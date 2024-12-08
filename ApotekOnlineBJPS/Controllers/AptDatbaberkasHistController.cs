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
    public class AptDatbaberkasHistController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AptDatbaberkasHistController(ApplicationDbContext context)
        {
            _applicationDbContext = context;
        }

        // GET: api/AptDatbaberkasHist
        [HttpGet]
        public async Task<IActionResult> GetAptDatbaberkasHists()
        {
            var records = await _applicationDbContext.AptDatbaberkasHists.ToListAsync();

            if (records == null || !records.Any())
            {
                return NotFound(new { message = "Tidak ada data ditemukan." });
            }

            return Ok(new { message = "Data ditemukan.", data = records });
        }

        // GET: api/AptDatbaberkasHist/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAptDatbaberkasHist(Guid id)
        {
            var record = await _applicationDbContext.AptDatbaberkasHists.FindAsync(id);

            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }

            return Ok(new { message = "Data ditemukan.", data = record });
        }

        // POST: api/AptDatbaberkasHist
        [HttpPost]
        public async Task<IActionResult> CreateAptDatbaberkasHist([FromBody] AptDatbaberkasHist model)
        {
            if (model == null)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }

            model.AptDatbaberkasHistId = Guid.NewGuid();
            _applicationDbContext.AptDatbaberkasHists.Add(model);
            await _applicationDbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAptDatbaberkasHist), new { id = model.AptDatbaberkasHistId }, model);
        }

        // PUT: api/AptDatbaberkasHist/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAptDatbaberkasHist(Guid id, [FromBody] AptDatbaberkasHist model)
        {
            if (model == null || id != model.AptDatbaberkasHistId)
            {
                return BadRequest(new { message = "Data tidak valid." });
            }

            var existingRecord = await _applicationDbContext.AptDatbaberkasHists.FindAsync(id);

            if (existingRecord == null)
            {
                return NotFound(new { message = "Data tidak ditemukan." });
            }

            existingRecord.Nopbk = model.Nopbk;
            existingRecord.Statuspb = model.Statuspb;
            existingRecord.Istolak = model.Istolak;
            existingRecord.Fuser = model.Fuser;
            existingRecord.Fdate = model.Fdate;

            _applicationDbContext.AptDatbaberkasHists.Update(existingRecord);
            await _applicationDbContext.SaveChangesAsync();

            return Ok(new { message = "Data berhasil diperbarui." });
        }

        // DELETE: api/AptDatbaberkasHist/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAptDatbaberkasHist(Guid id)
        {
            var record = await _applicationDbContext.AptDatbaberkasHists.FindAsync(id);

            if (record == null)
            {
                return NotFound(new { message = $"Data dengan ID {id} tidak ditemukan." });
            }

            _applicationDbContext.AptDatbaberkasHists.Remove(record);
            await _applicationDbContext.SaveChangesAsync();

            return Ok(new { message = "Data berhasil dihapus." });
        }

        // GET: api/AptDatbaberkasHist/paged
        [HttpGet("paged")]
        public IActionResult GetPagedAptDatbaberkas(int page = 1, int perPage = 2, string? search = null, string? orderBy = "CreateDateTime", string? sortDirection = "asc")
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }
            
            // Query dasar
            var query = _applicationDbContext.AptDatbaberkasHists.AsQueryable();

            // Filter berdasarkan search jika ada
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(u => u.Nopbk.Contains(search) || u.Fuser.Contains(search));
            }

            // Tambahkan order by
            if (!string.IsNullOrEmpty(orderBy))
            {
                query = sortDirection?.ToLower() == "desc"
                    ? query.OrderByDescending(e => EF.Property<object>(e, orderBy))
                    : query.OrderBy(e => EF.Property<object>(e, orderBy));
            }

            // Total Rows
            var totalRows = query.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            var rows = _applicationDbContext.AptDatbaberkasHists
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            var response = new
            {
                status = "success",
                message = "Data retrieved successfully",
                data = new
                {
                    rows,
                    totalRows,
                    currentPage = page,
                    perPage,
                    totalPages
                }
            };

            return Ok(response);
        }

    }
}
