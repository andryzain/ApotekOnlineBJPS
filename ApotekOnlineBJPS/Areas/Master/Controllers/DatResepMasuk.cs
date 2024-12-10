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

    public class DatResepMasukController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public DatResepMasukController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatResepMasuks()
        {
            var DatResepMasuk = _applicationDbContext.DatResepMasuks.ToList();
            if (DatResepMasuk == null || !DatResepMasuk.Any())
            {
                return NotFound(new { message = "Belum ada data DatResepMasuk." });
            }
            return Ok(DatResepMasuk);
        }

        [HttpPost]
        public IActionResult AddDatResepMasuk([FromBody] DatResepMasukViewModel pendataanResepMasuk)
        {
            if (ModelState.IsValid)
            {
                // Mendapatkan tanggal sekarang untuk penentuan format kode unik
                var dateNow = DateTimeOffset.Now;
                var setDateNow = dateNow.ToString("yyMMdd");

                // Mencari entri terakhir berdasarkan hari ini
                var lastCode = _applicationDbContext.DatResepMasuks
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
                var newEntry = new DatResepMasuk
                {
                    DatResepMasukId = Guid.NewGuid(),
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
                var isDuplicate = _applicationDbContext.DatResepMasuks
                    .Any(c => c.NoSEP == pendataanResepMasuk.NoSEP);

                if (!isDuplicate)
                {
                    _applicationDbContext.DatResepMasuks.Add(newEntry);
                    _applicationDbContext.SaveChanges();

                    return CreatedAtAction(nameof(AddDatResepMasuk), new { message = "Data berhasil ditambahkan!" }, newEntry);
                }
                else
                {
                    return Conflict(new { message = "Terdapat duplikasi data!" });
                }
            }

            return BadRequest(new { message = "Data tidak valid!" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDatResepMasuk(Guid id, [FromBody] DatResepMasukViewModel updateDatResepMasuk)
        {
            if (updateDatResepMasuk == null)
            {
                return BadRequest(new { message = "Data DatResepMasuk tidak boleh kosong." });
            }

            // Cari data berdasarkan ID
            var pendataanResepMasuk = _applicationDbContext.DatResepMasuks.Find(id);
            if (pendataanResepMasuk == null)
            {
                return NotFound(new { message = $"DatResepMasuk dengan ID {id} tidak ditemukan." });
            }

            try
            {
                // Perbarui data berdasarkan ViewModel
                pendataanResepMasuk.NoSEP = updateDatResepMasuk.NoSEP;
                pendataanResepMasuk.FaskesAsalResep = updateDatResepMasuk.FaskesAsalResep;
                pendataanResepMasuk.NoKartu = updateDatResepMasuk.NoKartu;
                pendataanResepMasuk.NmPeserta = updateDatResepMasuk.NmPeserta;
                pendataanResepMasuk.JnsKelamin = updateDatResepMasuk.JnsKelamin;
                pendataanResepMasuk.TglLahir = updateDatResepMasuk.TglLahir;
                pendataanResepMasuk.Pisat = updateDatResepMasuk.Pisat;
                pendataanResepMasuk.JnsPst = updateDatResepMasuk.JnsPst;
                pendataanResepMasuk.BadanUsaha = updateDatResepMasuk.BadanUsaha;
                pendataanResepMasuk.TglSEP = updateDatResepMasuk.TglSEP;
                pendataanResepMasuk.TglPulang = updateDatResepMasuk.TglPulang;
                pendataanResepMasuk.TkPlyn = updateDatResepMasuk.TkPlyn;
                pendataanResepMasuk.Diagnosa_awal = updateDatResepMasuk.Diagnosa_awal;
                pendataanResepMasuk.Poli = updateDatResepMasuk.Poli;
                pendataanResepMasuk.JnsResep = updateDatResepMasuk.JnsResep;
                pendataanResepMasuk.NoResep = updateDatResepMasuk.NoResep;
                pendataanResepMasuk.TglResep = updateDatResepMasuk.TglResep;
                pendataanResepMasuk.TglPelayanan = updateDatResepMasuk.TglPelayanan;
                pendataanResepMasuk.Pokter = updateDatResepMasuk.Pokter;
                pendataanResepMasuk.Iterasi = updateDatResepMasuk.Iterasi;

                // Tandai sebagai diperbarui
                pendataanResepMasuk.UpdateDateTime = DateTimeOffset.Now;
                pendataanResepMasuk.UpdateBy = Guid.NewGuid();

                // Simpan perubahan ke database
                _applicationDbContext.DatResepMasuks.Update(pendataanResepMasuk);
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
        public IActionResult DeleteDatResepMasuk(Guid id)
        {
            // Cari data berdasarkan ID
            var DatResepMasuk = _applicationDbContext.DatResepMasuks.Find(id);
            if (DatResepMasuk == null)
            {
                return NotFound($"DatResepMasuk dengan ID {id} tidak ditemukan.");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatResepMasuks.Remove(DatResepMasuk);

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
        public IActionResult GetPagedDatResepMasuks(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatResepMasuks.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatResepMasuks
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatResepMasuk>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatResepMasuk>
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