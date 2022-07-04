using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizza.Models;

namespace RazorPagesPizza.Areas.Identity.Data;

public class RazorPagesPizzaAuth : IdentityDbContext<RazorPagesPizzaUser>
{
    public RazorPagesPizzaAuth(DbContextOptions<RazorPagesPizzaAuth> options)
        : base(options)
    {
    }

    //public DbSet<UserAudit> UserAuditEvents { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
