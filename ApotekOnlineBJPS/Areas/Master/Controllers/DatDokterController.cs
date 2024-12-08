using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.MasterData.Models;
using ApotekOnlineBJPS.Areas.MasterData.ViewModels;
using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApotekOnlineBJPS.Areas.MasterData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Endpoint ini memerlukan token
    [EnableCors("AllowSpecific")]
    public class DatDokterController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DatDokterController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatDokters()
        {
            var dokter = _applicationDbContext.DatDokters.ToList();
            if (dokter == null || !dokter.Any())
            {
                return NotFound(new { message = "Belum ada data dokter PRB. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = dokter
            });
        }

        [HttpPost]
        public IActionResult AddDatDokters([FromBody] DatDokterViewModel vm)
        {           
            if (ModelState.IsValid)
            {
                var dokter = new DatDokter
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DATDOKTERID = Guid.NewGuid(),
                    KDPPK = vm.KDPPK,
                    NMPPK = vm.NMPPK,
                    KdDokter = vm.KdDokter,
                    NmDokter = vm.NmDokter,
                    KdSpesialist = vm.KdSpesialist,
                    NmSpesialist = vm.NmSpesialist,
                    FlagAktif = vm.FlagAktif,                 
                };

                var checkDuplicate = _applicationDbContext.DatDokters.Where(c => c.KDPPK == vm.KDPPK).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatDokters.Where(c => c.KDPPK == vm.KDPPK).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.DatDokters.Add(dokter);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetDatDokters), new { message = "Tambah Data Sukses || 201 Created" }, dokter);
                    }
                    else
                    {
                        return BadRequest(new { message = "Data tidak valid !!! || 400 Bad Request" });
                    }
                }
                else
                {
                    return Conflict(new { message = "Terdapat duplikasi data !!! || 409 Conflict Data" });
                }
            }
            else
            {
                return BadRequest(new { message = "Data tidak valid !!! || 400 Bad Request" });
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDatDokter(Guid id, [FromBody] DatDokter vm)
        {
            if (vm == null)
            {
                return BadRequest("Data dokter tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var dokter = _applicationDbContext.DatDokters.Find(id);
            if (dokter == null)
            {
                return NotFound($"dokter dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data dokter PRB
                dokter.KDPPK = vm.KDPPK;
                dokter.NMPPK = vm.NMPPK;
                dokter.KdDokter = vm.KdDokter;
                dokter.NmDokter = vm.NmDokter;
                dokter.KdSpesialist = vm.KdSpesialist;
                dokter.NmSpesialist = vm.NmSpesialist;
                dokter.FlagAktif = vm.FlagAktif;              

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatDokters.Update(dokter);

                // Simpan perubahan ke database
                _applicationDbContext.SaveChanges();

                return Ok(new { message = "Berhasil Update || 200 OK" });
            }
            catch (Exception ex)
            {
                // Tangani error jika terjadi masalah
                return StatusCode(500, $"Terjadi kesalahan saat memperbarui data: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDatDokter(Guid id)
        {
            // Cari data berdasarkan ID
            var dokter = _applicationDbContext.DatDokters.Find(id);
            if (dokter == null)
            {
                return NotFound($"dokter dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatDokters.Remove(dokter);

                // Simpan perubahan
                _applicationDbContext.SaveChanges();

                return Ok(new { message = "Berhasil Hapus || 200 OK" });
            }
            catch (Exception ex)
            {
                // Tangani error jika ada masalah
                return StatusCode(500, $"Terjadi kesalahan saat menghapus data: {ex.Message}");
            }
        }

        [HttpGet("paged")]
        public IActionResult GetPagedPendaftaranDatDokters(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatDokters.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatDokters
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatDokter>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatDokter>
                {
                    Rows = rows,
                    TotalRows = totalRows,
                    CurrentPage = page,
                    PerPage = perPage,
                    TotalPages = totalPages
                }
            };

            return Ok(response);
        }
    }
}
