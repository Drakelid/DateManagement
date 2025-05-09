using Microsoft.EntityFrameworkCore;
using DateManagement.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DateManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
