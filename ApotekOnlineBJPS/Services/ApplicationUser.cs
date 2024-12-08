using Microsoft.AspNetCore.Identity;

namespace ApotekOnlineBJPS.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string KodeUser { get; set; }
        public string NamaUser { get; set; }
        public string DatUserName { get; set; }
        public string DatPassword { get; set; }
        public string DatNama { get; set; }
        public string DatNoPegawai { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnline { get; set; }
    }
}
