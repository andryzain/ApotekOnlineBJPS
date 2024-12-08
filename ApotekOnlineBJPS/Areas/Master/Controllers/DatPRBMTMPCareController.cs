using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.Master.ViewModels;

namespace ApotekOnlineBJPS.Areas.MasterData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Endpoint ini memerlukan token
    [EnableCors("AllowSpecific")]

    public class DatPRBMTMPCareController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DatPRBMTMPCareController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatPRBMTMPCares()
        {
            var prbmtmpcare = _applicationDbContext.DatPRBMTMPCares.ToList();
            if (prbmtmpcare == null || !prbmtmpcare.Any())
            {
                return NotFound(new { message = "Belum ada data PRB MTM PCare. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = prbmtmpcare
            });
        }

        [HttpPost]
        public IActionResult AddDatPRBMTMPCares([FromBody] DatPRBMTMPCareViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var prbmtmpcare = new DatPRBMTMPCare
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DatPRBMTMPCareId = Guid.NewGuid(),
                    NoKunjungan = vm.NoKunjungan,
                    ResepMasukId = vm.ResepMasukId,
                    KdRiwAlergiObat = vm.KdRiwAlergiObat,
                    KetRiwAlergiObat = vm.KetRiwAlergiObat,
                    KdRiwEfekObat = vm.KdRiwEfekObat,
                    KetRiwEfekObat = vm.KetRiwEfekObat,
                    KdRiwMerokok = vm.KdRiwMerokok,
                    KetRiwMerokok = vm.KetRiwMerokok,
                    KdRiwObatTambahan = vm.KdRiwObatTambahan,
                    KetRiwObatTambahan = vm.KetRiwObatTambahan,
                    PerbaikanGejala = vm.PerbaikanGejala,
                    PerbaikanLab = vm.PerbaikanLab,
                    PenurunanRisiko = vm.PenurunanRisiko,
                    KDPPK_APOTIK = vm.KDPPK_APOTIK,
                    FUser = vm.FUser,
                    FDate = vm.FDate,
                    LUser = vm.LUser,
                    LDate = vm.LDate
                };

                var checkDuplicate = _applicationDbContext.DatPRBMTMPCares.Where(c => c.NoKunjungan == vm.NoKunjungan).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatPRBMTMPCares.Where(c => c.NoKunjungan == vm.NoKunjungan).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.DatPRBMTMPCares.Add(prbmtmpcare);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetDatPRBMTMPCares), new { message = "Tambah Data Sukses || 201 Created" }, prbmtmpcare);
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
        public IActionResult UpdateDatPRBMTMPCare(Guid id, [FromBody] DatPRBMTMPCare vm)
        {
            if (vm == null)
            {
                return BadRequest("Data prbmtmpcare tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var prbmtmpcare = _applicationDbContext.DatPRBMTMPCares.Find(id);
            if (prbmtmpcare == null)
            {
                return NotFound($"prbmtmpcare dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data prbmtmpcare PRB
                prbmtmpcare.NoKunjungan = vm.NoKunjungan;
                prbmtmpcare.ResepMasukId = vm.ResepMasukId;
                prbmtmpcare.KdRiwAlergiObat = vm.KdRiwAlergiObat;
                prbmtmpcare.KetRiwAlergiObat = vm.KetRiwAlergiObat;
                prbmtmpcare.KdRiwEfekObat = vm.KdRiwEfekObat;
                prbmtmpcare.KetRiwEfekObat = vm.KetRiwEfekObat;
                prbmtmpcare.KdRiwMerokok = vm.KdRiwMerokok;
                prbmtmpcare.KetRiwMerokok = vm.KetRiwMerokok;
                prbmtmpcare.KdRiwObatTambahan = vm.KdRiwObatTambahan;
                prbmtmpcare.KetRiwObatTambahan = vm.KetRiwObatTambahan;
                prbmtmpcare.PerbaikanGejala = vm.PerbaikanGejala;
                prbmtmpcare.PerbaikanLab = vm.PerbaikanLab;
                prbmtmpcare.PenurunanRisiko = vm.PenurunanRisiko;
                prbmtmpcare.KDPPK_APOTIK = vm.KDPPK_APOTIK;
                prbmtmpcare.FUser = vm.FUser;
                prbmtmpcare.FDate = vm.FDate;
                prbmtmpcare.LUser = vm.LUser;
                prbmtmpcare.LDate = vm.LDate;

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatPRBMTMPCares.Update(prbmtmpcare);

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
        public IActionResult DeleteDatPRBMTMPCare(Guid id)
        {
            // Cari data berdasarkan ID
            var prbmtmpcare = _applicationDbContext.DatPRBMTMPCares.Find(id);
            if (prbmtmpcare == null)
            {
                return NotFound($"PRB MTM PCare dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatPRBMTMPCares.Remove(prbmtmpcare);

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
        public IActionResult GetPagedPendaftaranDatPRBMTMPCares(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatPRBMTMPCares.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatPRBMTMPCares
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatPRBMTMPCare>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatPRBMTMPCare>
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
