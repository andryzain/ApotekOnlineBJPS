using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.Master.ViewModels;
using ApotekOnlineBJPS.Areas.MasterData.ViewModels;
using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using MessagePack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApotekOnlineBJPS.Areas.Master.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize] // Endpoint ini memerlukan token
    //[EnableCors("AllowSpecific")]
    public class DatSepPesertaController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public DatSepPesertaController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatSepPesertas()
        {
            var sepPeserta = _applicationDbContext.DatSepPesertas
    .Include(p => p.DatSep)
    .ToList();
            if (sepPeserta == null || !sepPeserta.Any())
            {
                return NotFound(new { message = "Belum ada data Sep Peserta. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = sepPeserta
            });
        }

        [HttpPost]
        public IActionResult AddDatSepPesertas([FromBody] DatSepPesertaViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var sepPeserta = new DatSepPeserta
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DATSEPPESERTAID = Guid.NewGuid(),
                    NOSEP = vm.NOSEP,
                    NOKAPST = vm.NOKAPST,
                    PSNOKALAMA = vm.PSNOKALAMA,
                    NOKA = vm.NOKA,
                    NMPST = vm.NMPST,
                    JKPST = vm.JKPST,
                    TGLLHRPST = vm.TGLLHRPST,
                    NIK = vm.NIK,
                    NOKTP = vm.NOKTP,
                    KKNO = vm.KKNO,
                    KDHUBKEL = vm.KDHUBKEL,
                    PISAPST = vm.PISAPST,
                    KDSTAWIN = vm.KDSTAWIN,
                    NMSTAWIN = vm.NMSTAWIN,
                    KDSTATUSPST = vm.KDSTATUSPST,
                    KETSTATUSPST = vm.KETSTATUSPST,
                    PPKPST = vm.PPKPST,
                    NMPPK = vm.NMPPK,
                    NOHP = vm.NOHP,
                    EMAIL = vm.EMAIL,
                    KDKANTOR = vm.KDKANTOR,
                    TMT = vm.TMT,
                    TAT = vm.TAT,
                    FLAGTANGGUNGAN = vm.FLAGTANGGUNGAN,
                    KDJNSPESERTA = vm.KDJNSPESERTA,
                    KETJNSPESERTA = vm.KETJNSPESERTA,
                    KDJNSPST = vm.KDJNSPST,
                    ALAMAT = vm.ALAMAT,
                    KDGOLDARAH = vm.KDGOLDARAH,
                    KDPPKPSTGIGI = vm.KDPPKPSTGIGI,
                    NMPPKPSTGIGI = vm.NMPPKPSTGIGI,
                    KDJNSKPST = vm.KDJNSKPST,
                    NMJNSKPST = vm.NMJNSKPST,
                    KDPKS = vm.KDPKS,
                    NMPKS = vm.NMPKS,
                    NIPBARU = vm.NIPBARU,
                    NIPLAMA = vm.NIPLAMA,
                    KDGOL = vm.KDGOL,
                    KETGOLRU = vm.KETGOLRU,
                    KDKELASI = vm.KDKELASI,
                    KDKELAS = vm.KDKELAS,
                    KETKELAS = vm.KETKELAS,
                    TGLCETAK = vm.TGLCETAK,
                    KDASURANSI = vm.KDASURANSI,
                    NOASUR = vm.NOASUR,
                    TMTASUR = vm.TMTASUR,
                    TATASUR = vm.TATASUR,
                    NMASURANSI = vm.NMASURANSI,
                    DINSOS = vm.DINSOS,
                    NAMABAYI = vm.NAMABAYI,
                    TMTPREMI = vm.TMTPREMI,
                    PREMI = vm.PREMI,
                    TMTPPK = vm.TMTPPK,
                    FLAGKOL = vm.FLAGKOL,
                    SKTM = vm.SKTM,
                    TGLSTATUS = vm.TGLSTATUS,
                    FIRSTAKTIF = vm.FIRSTAKTIF,
                };

                var checkDuplicate = _applicationDbContext.DatSepPesertas.Where(c => c.NOSEP == vm.NOSEP).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatSepPesertas.Where(c => c.NOSEP == vm.NOSEP).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.DatSepPesertas.Add(sepPeserta);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetDatSepPesertas), new { message = "Tambah Data Sukses || 201 Created" }, sepPeserta);
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
        public IActionResult UpdateDatSepPeserta(Guid id, [FromBody] DatSepPeserta vm)
        {
            if (vm == null)
            {
                return BadRequest("Data Sep Peserta tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var sepPeserta = _applicationDbContext.DatSepPesertas.Find(id);
            if (sepPeserta == null)
            {
                return NotFound($"sepPeserta dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data Sep Peserta                
                sepPeserta.NOSEP = vm.NOSEP;
                sepPeserta.NOKAPST = vm.NOKAPST;
                sepPeserta.PSNOKALAMA = vm.PSNOKALAMA;
                sepPeserta.NOKA = vm.NOKA;
                sepPeserta.NMPST = vm.NMPST;
                sepPeserta.JKPST = vm.JKPST;
                sepPeserta.TGLLHRPST = vm.TGLLHRPST;
                sepPeserta.NIK = vm.NIK;
                sepPeserta.NOKTP = vm.NOKTP;
                sepPeserta.KKNO = vm.KKNO;
                sepPeserta.KDHUBKEL = vm.KDHUBKEL;
                sepPeserta.PISAPST = vm.PISAPST;
                sepPeserta.KDSTAWIN = vm.KDSTAWIN;
                sepPeserta.NMSTAWIN = vm.NMSTAWIN;
                sepPeserta.KDSTATUSPST = vm.KDSTATUSPST;
                sepPeserta.KETSTATUSPST = vm.KETSTATUSPST;
                sepPeserta.PPKPST = vm.PPKPST;
                sepPeserta.NMPPK = vm.NMPPK;
                sepPeserta.NOHP = vm.NOHP;
                sepPeserta.EMAIL = vm.EMAIL;
                sepPeserta.KDKANTOR = vm.KDKANTOR;
                sepPeserta.TMT = vm.TMT;
                sepPeserta.TAT = vm.TAT;
                sepPeserta.FLAGTANGGUNGAN = vm.FLAGTANGGUNGAN;
                sepPeserta.KDJNSPESERTA = vm.KDJNSPESERTA;
                sepPeserta.KETJNSPESERTA = vm.KETJNSPESERTA;
                sepPeserta.KDJNSPST = vm.KDJNSPST;
                sepPeserta.ALAMAT = vm.ALAMAT;
                sepPeserta.KDGOLDARAH = vm.KDGOLDARAH;
                sepPeserta.KDPPKPSTGIGI = vm.KDPPKPSTGIGI;
                sepPeserta.NMPPKPSTGIGI = vm.NMPPKPSTGIGI;
                sepPeserta.KDJNSKPST = vm.KDJNSKPST;
                sepPeserta.NMJNSKPST = vm.NMJNSKPST;
                sepPeserta.KDPKS = vm.KDPKS;
                sepPeserta.NMPKS = vm.NMPKS;
                sepPeserta.NIPBARU = vm.NIPBARU;
                sepPeserta.NIPLAMA = vm.NIPLAMA;
                sepPeserta.KDGOL = vm.KDGOL;
                sepPeserta.KETGOLRU = vm.KETGOLRU;
                sepPeserta.KDKELASI = vm.KDKELASI;
                sepPeserta.KDKELAS = vm.KDKELAS;
                sepPeserta.KETKELAS = vm.KETKELAS;
                sepPeserta.TGLCETAK = vm.TGLCETAK;
                sepPeserta.KDASURANSI = vm.KDASURANSI;
                sepPeserta.NOASUR = vm.NOASUR;
                sepPeserta.TMTASUR = vm.TMTASUR;
                sepPeserta.TATASUR = vm.TATASUR;
                sepPeserta.NMASURANSI = vm.NMASURANSI;
                sepPeserta.DINSOS = vm.DINSOS;
                sepPeserta.NAMABAYI = vm.NAMABAYI;
                sepPeserta.TMTPREMI = vm.TMTPREMI;
                sepPeserta.PREMI = vm.PREMI;
                sepPeserta.TMTPPK = vm.TMTPPK;
                sepPeserta.FLAGKOL = vm.FLAGKOL;
                sepPeserta.SKTM = vm.SKTM;
                sepPeserta.TGLSTATUS = vm.TGLSTATUS;
                sepPeserta.FIRSTAKTIF = vm.FIRSTAKTIF;
                sepPeserta.DatSep = vm.DatSep;

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatSepPesertas.Update(sepPeserta);

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
        public IActionResult DeleteDatSepPeserta(Guid id)
        {
            // Cari data berdasarkan ID
            var sepPeserta = _applicationDbContext.DatSepPesertas.Find(id);
            if (sepPeserta == null)
            {
                return NotFound($"Sep Peserta dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatSepPesertas.Remove(sepPeserta);

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
        public IActionResult GetPagedPendaftaranDatSepPesertas(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatSepPesertas.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatSepPesertas
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatSepPeserta>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatSepPeserta>
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
