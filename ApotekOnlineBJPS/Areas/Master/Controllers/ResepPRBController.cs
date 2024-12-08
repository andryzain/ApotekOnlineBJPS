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
    public class ResepPRBController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ResepPRBController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetResepPRBs()
        {
            var resepprb = _applicationDbContext.ResepPRBs.ToList();
            if (resepprb == null || !resepprb.Any())
            {
                return NotFound(new { message = "Belum ada data resepprb PRB. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = resepprb
            });
        }

        [HttpPost]
        public IActionResult AddResepPRBs([FromBody] ResepPRBViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var resepprb = new ResepPRB
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    ResepPRBId = Guid.NewGuid(),
                    KdGenerik = vm.KdGenerik,
                    NmGenerik = vm.NmGenerik,
                    Signa1 = vm.Signa1,
                    Signa2 = vm.Signa2,
                    Signa = vm.Signa,
                    JmlObat = vm.JmlObat,
                    TglResep = vm.TglResep,
                };

                var checkDuplicate = _applicationDbContext.ResepPRBs.Where(c => c.KdGenerik == vm.KdGenerik).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.ResepPRBs.Where(c => c.KdGenerik == vm.KdGenerik).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.ResepPRBs.Add(resepprb);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetResepPRBs), new { message = "Tambah Data Sukses || 201 Created" }, resepprb);
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
        public IActionResult UpdateResepPRB(Guid id, [FromBody] ResepPRB vm)
        {
            if (vm == null)
            {
                return BadRequest("Data resepprb tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var resepprb = _applicationDbContext.ResepPRBs.Find(id);
            if (resepprb == null)
            {
                return NotFound($"resepprb dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data resepprb PRB
                resepprb.KdGenerik = vm.KdGenerik;
                resepprb.NmGenerik = vm.NmGenerik;
                resepprb.Signa1 = vm.Signa1;
                resepprb.Signa2 = vm.Signa2;
                resepprb.Signa = vm.Signa;
                resepprb.JmlObat = vm.JmlObat;
                resepprb.TglResep = vm.TglResep;

                // Tandai data sebagai telah diubah
                _applicationDbContext.ResepPRBs.Update(resepprb);

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
        public IActionResult DeleteResepPRB(Guid id)
        {
            // Cari data berdasarkan ID
            var resepprb = _applicationDbContext.ResepPRBs.Find(id);
            if (resepprb == null)
            {
                return NotFound($"Resep PRB dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.ResepPRBs.Remove(resepprb);

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
        public IActionResult GetPagedPendaftaranResepPRBs(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.ResepPRBs.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.ResepPRBs
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<ResepPRB>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<ResepPRB>
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
