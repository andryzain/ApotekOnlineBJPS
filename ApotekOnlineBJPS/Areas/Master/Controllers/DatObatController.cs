using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.Master.ViewModels;
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

    public class DatObatController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DatObatController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatObats()
        {
            var obat = _applicationDbContext.DatObats.ToList();
            if (obat == null || !obat.Any())
            {
                return NotFound(new { message = "Belum ada data obat PRB. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = obat
            });
        }

        [HttpPost]
        public IActionResult AddDatObats([FromBody] DatObatViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var obat = new DatObat
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DATOBATID = Guid.NewGuid(),
                    NOSJP = vm.NOSJP,
                    NORESEP = vm.NORESEP,
                    JNSROBT = vm.JNSROBT,
                    KDOBT = vm.KDOBT,
                    JMLOBT = vm.JMLOBT,
                    SIGNA1OBT = vm.SIGNA1OBT,
                    SIGNA2OBT = vm.SIGNA2OBT,
                    JHO = vm.JHO,
                    SERVICEOBT = vm.SERVICEOBT,
                    HRGTAGOBT = vm.HRGTAGOBT,
                    HRGVEROBT = vm.HRGVEROBT,
                    HRGSTJOBT = vm.HRGSTJOBT,
                    FLAGCOBT = vm.FLAGCOBT,
                    FLAGVOBT = vm.FLAGVOBT,
                    ALASANOBT = vm.ALASANOBT,
                    KDOBTVER = vm.KDOBTVER,
                    JMLOBTVER = vm.JMLOBTVER,
                    SIGNA1VER = vm.SIGNA1VER,
                    SIGNA2VER = vm.SIGNA2VER,
                    JHOVER = vm.JHOVER,
                    PERMINTAAN = vm.PERMINTAAN,
                    KEKUATAN = vm.KEKUATAN,
                    PERMINTAANVER = vm.PERMINTAANVER,
                    KEKUATANVER = vm.KEKUATANVER,
                    NOKONF = vm.NOKONF,
                    SEDIANDPHO = vm.SEDIANDPHO,
                    HDasarNDpho = vm.HDasarNDpho,
                    FaktorNDpho = vm.FaktorNDpho,
                    NMObatNDpho = vm.NMObatNDpho,
                    FaktorVer = vm.FaktorVer,
                    HDasarVer = vm.HDasarVer,
                    ServiceVer = vm.ServiceVer,
                    HDasar = vm.HDasar,
                    Faktor = vm.Faktor,
                    JMLOBTR = vm.JMLOBTR,
                    JMLOBTRVER = vm.JMLOBTRVER,
                    FlagTanggung = vm.FlagTanggung,
                    CatKhsObt = vm.CatKhsObt,
                    CatKhsObtVer = vm.CatKhsObtVer
                };

                var checkDuplicate = _applicationDbContext.DatObats.Where(c => c.NOSJP == vm.NOSJP).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatObats.Where(c => c.NOSJP == vm.NOSJP).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.DatObats.Add(obat);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetDatObats), new { message = "Tambah Data Sukses || 201 Created" }, obat);
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
        public IActionResult UpdateDatObat(Guid id, [FromBody] DatObat vm)
        {
            if (vm == null)
            {
                return BadRequest("Data obat tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var obat = _applicationDbContext.DatObats.Find(id);
            if (obat == null)
            {
                return NotFound($"obat dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data obat
                obat.NOSJP = vm.NOSJP;
                obat.NORESEP = vm.NORESEP;
                obat.JNSROBT = vm.JNSROBT;
                obat.KDOBT = vm.KDOBT;
                obat.JMLOBT = vm.JMLOBT;
                obat.SIGNA1OBT = vm.SIGNA1OBT;
                obat.SIGNA2OBT = vm.SIGNA2OBT;
                obat.JHO = vm.JHO;
                obat.SERVICEOBT = vm.SERVICEOBT;
                obat.HRGTAGOBT = vm.HRGTAGOBT;
                obat.HRGVEROBT = vm.HRGVEROBT;
                obat.HRGSTJOBT = vm.HRGSTJOBT;
                obat.FLAGCOBT = vm.FLAGCOBT;
                obat.FLAGVOBT = vm.FLAGVOBT;
                obat.ALASANOBT = vm.ALASANOBT;
                obat.KDOBTVER = vm.KDOBTVER;
                obat.JMLOBTVER = vm.JMLOBTVER;
                obat.SIGNA1VER = vm.SIGNA1VER;
                obat.SIGNA2VER = vm.SIGNA2VER;
                obat.JHOVER = vm.JHOVER;
                obat.PERMINTAAN = vm.PERMINTAAN;
                obat.KEKUATAN = vm.KEKUATAN;
                obat.PERMINTAANVER = vm.PERMINTAANVER;
                obat.KEKUATANVER = vm.KEKUATANVER;
                obat.NOKONF = vm.NOKONF;
                obat.SEDIANDPHO = vm.SEDIANDPHO;
                obat.HDasarNDpho = vm.HDasarNDpho;
                obat.FaktorNDpho = vm.FaktorNDpho;
                obat.NMObatNDpho = vm.NMObatNDpho;
                obat.FaktorVer = vm.FaktorVer;
                obat.HDasarVer = vm.HDasarVer;
                obat.ServiceVer = vm.ServiceVer;
                obat.HDasar = vm.HDasar;
                obat.Faktor = vm.Faktor;
                obat.JMLOBTR = vm.JMLOBTR;
                obat.JMLOBTRVER = vm.JMLOBTRVER;
                obat.FlagTanggung = vm.FlagTanggung;
                obat.CatKhsObt = vm.CatKhsObt;
                obat.CatKhsObtVer = vm.CatKhsObtVer;

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatObats.Update(obat);

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
        public IActionResult DeleteDatObat(Guid id)
        {
            // Cari data berdasarkan ID
            var obat = _applicationDbContext.DatObats.Find(id);
            if (obat == null)
            {
                return NotFound($"obat dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatObats.Remove(obat);

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
        public IActionResult GetPagedPendaftaranDatObats(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatObats.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatObats
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatObat>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatObat>
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
