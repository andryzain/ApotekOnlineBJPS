using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ApotekOnlineBJPS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AptDatbaberkasController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AptDatbaberkasController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Get All AptDatbaberkas
        [HttpGet]
        public IActionResult GetAptDatbaberkas()
        {
            var data = _applicationDbContext.AptDatbaberkass.ToList();
            if (data == null || !data.Any())
            {
                return NotFound(new { message = "Data tidak ditemukan || 404 Not Found" });
            }
            return Ok(new { message = "Berhasil mengambil data || 200 OK", data });
        }

        // Add a new AptDatbaberkas
        [HttpPost]
        public IActionResult AddAptDatbaberkas([FromBody] AptDatbaberkas aptDatbaberkas)
        {
            if (aptDatbaberkas == null)
            {
                return BadRequest(new { message = "Data tidak valid || 400 Bad Request" });
            }

            // Set metadata fields
            aptDatbaberkas.AptDatbaberkasId = Guid.NewGuid();
            aptDatbaberkas.Fdate = DateTime.Now;

            _applicationDbContext.AptDatbaberkass.Add(aptDatbaberkas);
            _applicationDbContext.SaveChanges();

            return CreatedAtAction(nameof(GetAptDatbaberkas), new { message = "Tambah Data Sukses || 201 Created" }, aptDatbaberkas);
        }

        // Update an existing AptDatbaberkas
        [HttpPut("{id}")]
        public IActionResult UpdateAptDatbaberkas(Guid id, [FromBody] AptDatbaberkas updateAptDatbaberkas)
        {
            if (updateAptDatbaberkas == null)
            {
                return BadRequest(new { message = "Data tidak valid || 400 Bad Request" });
            }

            var aptDatbaberkas = _applicationDbContext.AptDatbaberkass.Find(id);
            if (aptDatbaberkas == null)
            {
                return NotFound(new { message = "Data tidak ditemukan || 404 Not Found" });
            }

            // Update fields
            aptDatbaberkas.Nopbk = updateAptDatbaberkas.Nopbk;
            aptDatbaberkas.Statuspb = updateAptDatbaberkas.Statuspb;
            aptDatbaberkas.Nosurat = updateAptDatbaberkas.Nosurat;
            aptDatbaberkas.Tglentri = updateAptDatbaberkas.Tglentri;
            aptDatbaberkas.Tglba = updateAptDatbaberkas.Tglba;
            aptDatbaberkas.Noreff = updateAptDatbaberkas.Noreff;
            aptDatbaberkas.Tglselesai = updateAptDatbaberkas.Tglselesai;
            aptDatbaberkas.Tgljthtempo = updateAptDatbaberkas.Tgljthtempo;
            aptDatbaberkas.Nmpetugas = updateAptDatbaberkas.Nmpetugas;
            aptDatbaberkas.Nippetugas = updateAptDatbaberkas.Nippetugas;
            aptDatbaberkas.Nmdirektur = updateAptDatbaberkas.Nmdirektur;
            aptDatbaberkas.Nipdirektur = updateAptDatbaberkas.Nipdirektur;
            aptDatbaberkas.Keterangan = updateAptDatbaberkas.Keterangan;

            // Mark as updated
            aptDatbaberkas.Ldate = DateTime.Now;

            _applicationDbContext.AptDatbaberkass.Update(aptDatbaberkas);
            _applicationDbContext.SaveChanges();

            return Ok(new { message = "Berhasil Update || 200 OK" });
        }

        // Delete an AptDatbaberkas
        [HttpDelete("{id}")]
        public IActionResult DeleteAptDatbaberkas(Guid id)
        {
            var aptDatbaberkas = _applicationDbContext.AptDatbaberkass.Find(id);
            if (aptDatbaberkas == null)
            {
                return NotFound(new { message = "Data tidak ditemukan || 404 Not Found" });
            }

            _applicationDbContext.AptDatbaberkass.Remove(aptDatbaberkas);
            _applicationDbContext.SaveChanges();

            return Ok(new { message = "Berhasil Hapus || 200 OK" });
        }

        // Get Paginated AptDatbaberkas
        [HttpGet("paged")]
        public IActionResult GetPagedAptDatbaberkas(int page = 1, int perPage = 2, string? search = null, string? orderBy = "CreateDateTime", string? sortDirection = "asc")
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Query dasar
            var query = _applicationDbContext.AptDatbaberkass.AsQueryable();

            // Filter berdasarkan search jika ada
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(u => u.Nopbk.Contains(search) || u.Nosurat.Contains(search) || u.Nmpetugas.Contains(search)); // Sesuaikan properti dengan kebutuhan
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

            var rows = _applicationDbContext.AptDatbaberkass
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
