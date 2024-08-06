using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CodeAlpha_Project_BookLibrary.Models;

namespace CodeAlpha_Project_BookLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CodeAlpha_Project_BookLibrary.Models.Book> Book { get; set; } = default!;
    }
}
