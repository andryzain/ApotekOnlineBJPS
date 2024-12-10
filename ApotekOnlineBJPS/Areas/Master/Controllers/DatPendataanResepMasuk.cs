using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.Master.ViewModels;
using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BPJSApotekOnlineDeveloper.Areas.MasterData.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Endpoint ini memerlukan token
    [EnableCors("AllowSpecific")]

    public class DatPendataanResepMasukController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DatPendataanResepMasukController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatPendataanResepMasuks()
        {
            var DatPendataanResepMasuk = _applicationDbContext.DatPendataanResepMasuks.ToList();
            if (DatPendataanResepMasuk == null || !DatPendataanResepMasuk.Any())
            {
                return NotFound(new { message = "Belum ada data DatPendataanResepMasuk." });
            }
            return Ok(DatPendataanResepMasuk);
        }

        [HttpPost]
        public IActionResult AddDatPendataanResepMasuk([FromBody] DatPendataanResepMasukViewModel pendataanResepMasuk)
        {
            if (ModelState.IsValid)
            {
                // Mendapatkan tanggal sekarang untuk penentuan format kode unik
                var dateNow = DateTimeOffset.Now;
                var setDateNow = dateNow.ToString("yyMMdd");

                // Mencari entri terakhir berdasarkan hari ini
                var lastCode = _applicationDbContext.DatPendataanResepMasuks
                    .Where(d => d.CreateDateTime.Date == dateNow.Date)
                    .OrderByDescending(k => k.NoSEP)
                    .FirstOrDefault();

                // Menentukan nilai NoSEP berdasarkan entri terakhir
                if (lastCode == null)
                {
                    pendataanResepMasuk.NoSEP = "SEP" + setDateNow + "0001";
                }
                else
                {
                    var lastCodeNumber = Convert.ToInt32(lastCode.NoSEP.Substring(9));
                    pendataanResepMasuk.NoSEP = "SEP" + setDateNow + (lastCodeNumber + 1).ToString("D4");
                }

                // Membuat instance baru berdasarkan model yang diterima
                var newEntry = new DatPendataanResepMasuk
                {
                    DatPendataanResepMasukId = Guid.NewGuid(),
                    NoSEP = pendataanResepMasuk.NoSEP,
                    FaskesAsalResep = pendataanResepMasuk.FaskesAsalResep,
                    NoKartu = pendataanResepMasuk.NoKartu,
                    NmPeserta = pendataanResepMasuk.NmPeserta,
                    JnsKelamin = pendataanResepMasuk.JnsKelamin,
                    TglLahir = pendataanResepMasuk.TglLahir,
                    Pisat = pendataanResepMasuk.Pisat,
                    JnsPst = pendataanResepMasuk.JnsPst,
                    BadanUsaha = pendataanResepMasuk.BadanUsaha,
                    TglSEP = pendataanResepMasuk.TglSEP,
                    TglPulang = pendataanResepMasuk.TglPulang,
                    TkPlyn = pendataanResepMasuk.TkPlyn,
                    Diagnosa_awal = pendataanResepMasuk.Diagnosa_awal,
                    Poli = pendataanResepMasuk.Poli,
                    JnsResep = pendataanResepMasuk.JnsResep,
                    NoResep = pendataanResepMasuk.NoResep,
                    TglResep = pendataanResepMasuk.TglResep,
                    TglPelayanan = pendataanResepMasuk.TglPelayanan,
                    Pokter = pendataanResepMasuk.Pokter,
                    Iterasi = pendataanResepMasuk.Iterasi,
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = Guid.Empty,
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = Guid.Empty
                };

                // Mengecek duplikasi data
                var isDuplicate = _applicationDbContext.DatPendataanResepMasuks
                    .Any(c => c.NoSEP == pendataanResepMasuk.NoSEP);

                if (!isDuplicate)
                {
                    _applicationDbContext.DatPendataanResepMasuks.Add(newEntry);
                    _applicationDbContext.SaveChanges();

                    return CreatedAtAction(nameof(AddDatPendataanResepMasuk), new { message = "Data berhasil ditambahkan!" }, newEntry);
                }
                else
                {
                    return Conflict(new { message = "Terdapat duplikasi data!" });
                }
            }

            return BadRequest(new { message = "Data tidak valid!" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDatPendataanResepMasuk(Guid id, [FromBody] DatPendataanResepMasukViewModel updateDatPendataanResepMasuk)
        {
            if (updateDatPendataanResepMasuk == null)
            {
                return BadRequest(new { message = "Data DatPendataanResepMasuk tidak boleh kosong." });
            }

            // Cari data berdasarkan ID
            var pendataanResepMasuk = _applicationDbContext.DatPendataanResepMasuks.Find(id);
            if (pendataanResepMasuk == null)
            {
                return NotFound(new { message = $"DatPendataanResepMasuk dengan ID {id} tidak ditemukan." });
            }

            try
            {
                // Perbarui data berdasarkan ViewModel
                pendataanResepMasuk.NoSEP = updateDatPendataanResepMasuk.NoSEP;
                pendataanResepMasuk.FaskesAsalResep = updateDatPendataanResepMasuk.FaskesAsalResep;
                pendataanResepMasuk.NoKartu = updateDatPendataanResepMasuk.NoKartu;
                pendataanResepMasuk.NmPeserta = updateDatPendataanResepMasuk.NmPeserta;
                pendataanResepMasuk.JnsKelamin = updateDatPendataanResepMasuk.JnsKelamin;
                pendataanResepMasuk.TglLahir = updateDatPendataanResepMasuk.TglLahir;
                pendataanResepMasuk.Pisat = updateDatPendataanResepMasuk.Pisat;
                pendataanResepMasuk.JnsPst = updateDatPendataanResepMasuk.JnsPst;
                pendataanResepMasuk.BadanUsaha = updateDatPendataanResepMasuk.BadanUsaha;
                pendataanResepMasuk.TglSEP = updateDatPendataanResepMasuk.TglSEP;
                pendataanResepMasuk.TglPulang = updateDatPendataanResepMasuk.TglPulang;
                pendataanResepMasuk.TkPlyn = updateDatPendataanResepMasuk.TkPlyn;
                pendataanResepMasuk.Diagnosa_awal = updateDatPendataanResepMasuk.Diagnosa_awal;
                pendataanResepMasuk.Poli = updateDatPendataanResepMasuk.Poli;
                pendataanResepMasuk.JnsResep = updateDatPendataanResepMasuk.JnsResep;
                pendataanResepMasuk.NoResep = updateDatPendataanResepMasuk.NoResep;
                pendataanResepMasuk.TglResep = updateDatPendataanResepMasuk.TglResep;
                pendataanResepMasuk.TglPelayanan = updateDatPendataanResepMasuk.TglPelayanan;
                pendataanResepMasuk.Pokter = updateDatPendataanResepMasuk.Pokter;
                pendataanResepMasuk.Iterasi = updateDatPendataanResepMasuk.Iterasi;

                // Tandai sebagai diperbarui
                pendataanResepMasuk.UpdateDateTime = DateTimeOffset.Now;
                pendataanResepMasuk.UpdateBy = Guid.NewGuid();

                // Simpan perubahan ke database
                _applicationDbContext.DatPendataanResepMasuks.Update(pendataanResepMasuk);
                _applicationDbContext.SaveChanges();

                return Ok(new { message = "Data berhasil diperbarui." }); // 200 OK dengan pesan sukses
            }
            catch (Exception ex)
            {
                // Tangani error jika terjadi masalah
                return StatusCode(500, new { message = $"Terjadi kesalahan saat memperbarui data: {ex.Message}" });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDatPendataanResepMasuk(Guid id)
        {
            // Cari data berdasarkan ID
            var DatPendataanResepMasuk = _applicationDbContext.DatPendataanResepMasuks.Find(id);
            if (DatPendataanResepMasuk == null)
            {
                return NotFound($"DatPendataanResepMasuk dengan ID {id} tidak ditemukan.");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatPendataanResepMasuks.Remove(DatPendataanResepMasuk);

                // Simpan perubahan
                _applicationDbContext.SaveChanges();

                return NoContent(); // 204 No Content jika berhasil dihapus
            }
            catch (Exception ex)
            {
                // Tangani error jika ada masalah
                return StatusCode(500, $"Terjadi kesalahan saat menghapus data: {ex.Message}");
            }
        }

        [HttpGet("paged")]
        public IActionResult GetPagedDatPendataanResepMasuks(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatPendataanResepMasuks.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatPendataanResepMasuks
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatPendataanResepMasuk>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatPendataanResepMasuk>
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