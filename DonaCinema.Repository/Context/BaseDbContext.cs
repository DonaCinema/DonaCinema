using DonaCinema.BusinessObject.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonaCinema.Repository.Context
{
    public abstract class BaseDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        protected BaseDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public async Task<int> AsynSaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync();
        }
    }
}
