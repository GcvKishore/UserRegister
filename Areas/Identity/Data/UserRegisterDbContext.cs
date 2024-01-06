using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserRegister.Areas.Identity.Data;

namespace UserRegister.Data;

public class UserRegisterDbContext : IdentityDbContext<UserRegisterUser>
{
    public UserRegisterDbContext(DbContextOptions<UserRegisterDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
