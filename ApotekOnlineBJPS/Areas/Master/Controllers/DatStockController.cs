using ApotekOnlineBJPS.Areas.Master.Models;
using ApotekOnlineBJPS.Areas.MasterData.ViewModels;
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
    public class DatStockController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DatStockController(
            ApplicationDbContext applicationDbContext
        )
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public IActionResult GetDatStocks()
        {
            var stock = _applicationDbContext.DatStocks.ToList();
            if (stock == null || !stock.Any())
            {
                return NotFound(new { message = "Belum ada data stock PRB. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = stock
            });
        }

        [HttpPost]
        public IActionResult AddDatStocks([FromBody] DatStockViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var stock = new DatStock
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DATSTOCKID = Guid.NewGuid(),
                    KDPPK = vm.KDPPK,
                    KDOBAT = vm.KDOBAT,
                    TGLMUT = vm.TGLMUT,
                    Stok = vm.Stok,
                    STOKMINIM = vm.STOKMINIM
                };

                var checkDuplicate = _applicationDbContext.DatStocks.Where(c => c.KDPPK == vm.KDPPK).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatStocks.Where(c => c.KDPPK == vm.KDPPK).FirstOrDefault();
                    if (result == null)
                    {
                        _applicationDbContext.DatStocks.Add(stock);
                        _applicationDbContext.SaveChanges();
                        return CreatedAtAction(nameof(GetDatStocks), new { message = "Tambah Data Sukses || 201 Created" }, stock);
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
        public IActionResult UpdateDatStock(Guid id, [FromBody] DatStock vm)
        {
            if (vm == null)
            {
                return BadRequest("Data stock tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var stock = _applicationDbContext.DatStocks.Find(id);
            if (stock == null)
            {
                return NotFound($"stock dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data stock PRB
                stock.KDPPK = vm.KDPPK;
                stock.KDOBAT = vm.KDOBAT;
                stock.TGLMUT = vm.TGLMUT;
                stock.Stok = vm.Stok;
                stock.STOKMINIM = vm.STOKMINIM;

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatStocks.Update(stock);

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
        public IActionResult DeleteDatStock(Guid id)
        {
            // Cari data berdasarkan ID
            var stock = _applicationDbContext.DatStocks.Find(id);
            if (stock == null)
            {
                return NotFound($"stock dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus entitas dari database
                _applicationDbContext.DatStocks.Remove(stock);

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
        public IActionResult GetPagedPendaftaranDatStocks(int page = 1, int perPage = 2)
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Total Rows
            var totalRows = _applicationDbContext.DatStocks.Count();

            // Total Pages
            var totalPages = (int)Math.Ceiling(totalRows / (double)perPage);

            // Ambil Data Berdasarkan Pagination
            var rows = _applicationDbContext.DatStocks
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatStock>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatStock>
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
