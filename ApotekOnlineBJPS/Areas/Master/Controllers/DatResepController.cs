using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.Master.ViewModels;
using ApotekOnlineBJPS.Models;
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
    public class DatResepController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public DatResepController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatReseps()
        {
            var resep = _applicationDbContext.DatReseps.ToList();
            if (resep == null || !resep.Any())
            {
                return NotFound(new { message = "Belum ada data resep PRB. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = resep
            });
        }

        [HttpPost]
        public IActionResult AddDatReseps([FromBody] DatResepViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var resep = new DatResep
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DATRESEPID = Guid.NewGuid(),
                    NOSJP = vm.NOSJP,
                    NORESEP = vm.NORESEP,
                    TKPRSP = vm.TKPRSP,
                    POLIRSP = vm.POLIRSP,
                    UPFRSP = vm.UPFRSP,
                    TGLPELRSP = vm.TGLPELRSP,
                    TGLRSP = vm.TGLRSP,
                    BYTAGRSP = vm.BYTAGRSP,
                    BYVERRSP = vm.BYVERRSP,
                    BYSTJRSP = vm.BYSTJRSP,
                    FLAGTIRSP = vm.FLAGTIRSP,
                    NORESEPAPT = vm.NORESEPAPT,
                    KdDokter = vm.KdDokter,
                    NmDokter = vm.NmDokter,
                    Status = vm.Status,
                    FlagKirim = vm.FlagKirim,
                    TglKirim = vm.TglKirim,
                    TGLVER = vm.TGLVER,
                    Iterasi = vm.Iterasi,
                    CountIterasi = vm.CountIterasi,
                };

                var checkDuplicate = _applicationDbContext.DatReseps.Where(c => c.NORESEP == vm.NORESEP).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatReseps.Where(c => c.NORESEP == vm.NORESEP).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.DatReseps.Add(resep);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetDatReseps), new { message = "Tambah Data Sukses || 201 Created" }, resep);
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
        public IActionResult UpdateDatResep(Guid id, [FromBody] DatResep vm)
        {
            if (vm == null)
            {
                return BadRequest("Data resep tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var resep = _applicationDbContext.DatReseps.Find(id);
            if (resep == null)
            {
                return NotFound($"resep dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data resep PRB
                resep.NOSJP = vm.NOSJP;
                resep.NORESEP = vm.NORESEP;
                resep.TKPRSP = vm.TKPRSP;
                resep.POLIRSP = vm.POLIRSP;
                resep.UPFRSP = vm.UPFRSP;
                resep.TGLPELRSP = vm.TGLPELRSP;
                resep.TGLRSP = vm.TGLRSP;
                resep.BYTAGRSP = vm.BYTAGRSP;
                resep.BYVERRSP = vm.BYVERRSP;
                resep.BYSTJRSP = vm.BYSTJRSP;
                resep.FLAGTIRSP = vm.FLAGTIRSP;
                resep.NORESEPAPT = vm.NORESEPAPT;
                resep.KdDokter = vm.KdDokter;
                resep.NmDokter = vm.NmDokter;
                resep.Status = vm.Status;
                resep.FlagKirim = vm.FlagKirim;
                resep.TglKirim = vm.TglKirim;
                resep.TGLVER = vm.TGLVER;
                resep.Iterasi = vm.Iterasi;
                resep.CountIterasi = vm.CountIterasi;

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatReseps.Update(resep);

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
        public IActionResult DeleteDatResep(Guid id)
        {
            // Cari data berdasarkan ID
            var resep = _applicationDbContext.DatReseps.Find(id);
            if (resep == null)
            {
                return NotFound($"Resep dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatReseps.Remove(resep);

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
        public IActionResult GetPagedPendaftaranDatReseps(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatReseps.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatReseps
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatResep>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatResep>
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
