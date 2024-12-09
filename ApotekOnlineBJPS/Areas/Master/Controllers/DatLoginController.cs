using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using ApotekOnlineBJPS.Models;
using ApotekOnlineBJPS.Repositories;
using ApotekOnlineBJPS.Areas.Master.ViewModels;
using ApotekOnlineBJPS.Areas.Master.Models;

namespace ApotekOnlineBJPS.Areas.MasterData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Endpoint ini memerlukan token
    [EnableCors("AllowSpecific")]

    public class DatLoginController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<DatLoginController> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DatLoginController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,

            ApplicationDbContext applicationDbContext,
            ILogger<DatLoginController> logger,
            IHostingEnvironment hostingEnvironment
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;

            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult GetDatLogins()
        {
            var user = _applicationDbContext.DatLogins.ToList();
            if (user == null || !user.Any())
            {
                return NotFound(new { message = "Belum ada data user. || 404 Not Found" });
            }
            return Ok(new
            {
                message = "Berhasil || 200 OK",
                data = user
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] DatLoginViewModel vm)
        {          
            // Validate ModelState
            if (ModelState.IsValid)
            {
                var userLogin = new ApplicationUser
                {
                    KodeUser = vm.NOPEG,
                    NamaUser = vm.Nama,
                    //DatUserName = vm.UserName,
                    //DatPassword = vm.Password,
                    //DatNama = vm.Nama,
                    //DatNoPegawai = vm.NOPEG,
                    Email = vm.Email,
                    UserName = vm.Email,
                    IsActive = true
                };

                var user = new DatLogin
                {
                    CreateDateTime = DateTimeOffset.Now,
                    CreateBy = Guid.NewGuid(),
                    UpdateDateTime = DateTimeOffset.MinValue,
                    UpdateBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    DeleteDateTime = DateTimeOffset.MinValue,
                    DeleteBy = new Guid("00000000-0000-0000-0000-000000000000"),
                    UserId = Guid.NewGuid(),
                    UserName = vm.UserName,
                    Nama = vm.Nama,
                    NOPEG = vm.NOPEG,
                    FirstName = vm.FirstName,
                    LastName = vm.LastName,
                    Password = vm.Password,
                    KdJnsUser = vm.KdJnsUser,
                    KdGrupUserApp = vm.KdGrupUserApp,
                    NmGrupUserApp = vm.NmGrupUserApp,
                    FlagKantor = vm.FlagKantor,
                    KDPPK = vm.KDPPK,
                    NMPPK = vm.NMPPK,
                    KDDATI2 = vm.KDDATI2,
                    NMDATI2 = vm.NMDATI2,
                    KDKC = vm.KDKC,
                    NMKC = vm.NMKC,
                    KDPROP = vm.KDPROP,
                    NMPROP = vm.NMPROP,
                    KDKR = vm.KDKR,
                    NMKR = vm.NMKR,
                    Email = vm.Email,
                    IsAdmin = vm.IsAdmin,
                    IsAktif = vm.IsAktif,
                    LokasiID = vm.LokasiID,
                };

                var checkDuplicate = _applicationDbContext.DatLogins.Where(c => c.NOPEG == vm.NOPEG && c.UserName == vm.UserName).ToList();

                if (checkDuplicate.Count == 0)
                {
                    var result = _applicationDbContext.DatLogins.Where(c => c.NOPEG == vm.NOPEG && c.UserName == vm.UserName).FirstOrDefault();
                    if (result == null)
                    {
                        var resultLogin = await _userManager.CreateAsync(userLogin, vm.Password);

                        if (resultLogin.Succeeded)
                        {
                            _applicationDbContext.DatLogins.Add(user);
                            _applicationDbContext.SaveChanges();
                            return CreatedAtAction(nameof(GetDatLogins), new { message = "Tambah Data Berhasil || 201 Created" }, vm);
                        }
                        else
                        {
                            return BadRequest(new { message = "Data tidak valid !!! || 400 Bad Request" });
                        }
                    }
                    else
                    {
                        return BadRequest(new { message = "Data tidak dapat di input !!! || 400 Bad Request" });
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
        public IActionResult UpdateUser(Guid id, [FromBody] DatLoginViewModel vm)
        {
            if (vm == null)
            {
                return BadRequest("Data user tidak boleh kosong. || 400 Bad Request");
            }

            // Cari data berdasarkan ID
            var user = _applicationDbContext.DatLogins.Find(id);
            if (user == null)
            {
                return NotFound($"User dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Perbarui data user
                user.UserName = vm.UserName;
                user.Nama = vm.Nama;
                user.NOPEG = vm.NOPEG;
                user.FirstName = vm.FirstName;
                user.LastName = vm.LastName;
                user.Password = vm.Password;
                user.KdJnsUser = vm.KdJnsUser;
                user.KdGrupUserApp = vm.KdGrupUserApp;
                user.NmGrupUserApp = vm.NmGrupUserApp;
                user.FlagKantor = vm.FlagKantor;
                user.KDPPK = vm.KDPPK;
                user.NMPPK = vm.NMPPK;
                user.KDDATI2 = vm.KDDATI2;
                user.NMDATI2 = vm.NMDATI2;
                user.KDKC = vm.KDKC;
                user.NMKC = vm.NMKC;
                user.KDPROP = vm.KDPROP;
                user.NMPROP = vm.NMPROP;
                user.KDKR = vm.KDKR;
                user.NMKR = vm.NMKR;
                user.Email = vm.Email;
                user.IsAdmin = vm.IsAdmin;
                user.IsAktif = vm.IsAktif;
                user.LokasiID = vm.LokasiID;

                // Tandai data sebagai telah diubah
                _applicationDbContext.DatLogins.Update(user);

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
        public IActionResult DeleteUser(Guid id)
        {
            // Cari data berdasarkan ID
            var user = _applicationDbContext.DatLogins.Find(id);
            if (user == null)
            {
                return NotFound($"User dengan ID {id} tidak ditemukan. || 404 Not Found");
            }

            try
            {
                // Hapus Akun Login
                var userLogin = _signInManager.UserManager.Users.FirstOrDefault(s => s.DatNoPegawai == user.NOPEG);
                _applicationDbContext.Attach(userLogin);
                _applicationDbContext.Entry(userLogin).State = EntityState.Deleted;
                _applicationDbContext.SaveChanges();

                // Hapus entitas dari database
                _applicationDbContext.DatLogins.Remove(user);

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
        public IActionResult GetPagedUsers(int page = 1, int perPage = 2, string? search = null, string? orderBy = "CreateDateTime", string? sortDirection = "asc")
        {
            if (page <= 0 || perPage <= 0)
            {
                return BadRequest(new { status = "error", message = "Page and perPage must be greater than 0." });
            }

            // Query dasar
            var query = _applicationDbContext.DatLogins.AsQueryable();

            // Filter berdasarkan search jika ada
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(u => u.UserName.Contains(search) || u.Nama.Contains(search) || u.FirstName.Contains(search) || u.NOPEG.Contains(search) || u.Email.Contains(search)); // Sesuaikan properti dengan kebutuhan
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

            // Ambil Data Berdasarkan Pagination
            var rows = query
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            if (rows.Count == 0 && page > totalPages)
            {
                return NotFound(new { status = "error", message = "Page not found." });
            }

            // Buat Respons
            var response = new ApiResponse<PaginatedData<DatLogin>>
            {
                Status = "success",
                Message = "Data retrieved successfully",
                Data = new PaginatedData<DatLogin>
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
