using Microsoft.AspNetCore.Identity;

namespace SalaryCapData.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
