using LoginSignup.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginSignup.Data;

public class LoginSignupDbContext : IdentityDbContext<LoginSignupUser>
{
    public LoginSignupDbContext(DbContextOptions<LoginSignupDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}

// public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<LoginSignupUser>
// {
//     public void Configure(EntityTypeBuilder<LoginSignupUser> builder)
//     {
//         builder.Property(x => x.FirstNAme).HasMaxLength(100);
//         builder.Property(x => x.LastName).HasMaxLength(100);
//
//     }
// }

