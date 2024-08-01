using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIMS_DEMO003.Models;
using SIMS_DEMO003.Data;

namespace SIMS_DEMO003.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<SIMS_DEMO003.Models.Semesters> Semesters { get; set; } = default!;
        public DbSet<SIMS_DEMO003.Models.Departments> Departments { get; set; } = default!;
        public DbSet<SIMS_DEMO003.Models.Majors> Majors { get; set; } = default!;
        
        
    }
}
