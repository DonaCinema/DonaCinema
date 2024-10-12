using DonaCinema.BusinessObject.Enum;
using DonaCinema.BusinessObject.Models.Auth;
using DonaCinema.Service.Interface;
using Microsoft.AspNetCore.Identity;

namespace DonaCinema.Service.Service
{
    public class AuthService : IAuthService
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<AuthResponse> SeedRolesAsync()
        {
            var isOwnerRoleExists = await _roleManager.RoleExistsAsync(StaticUserRoles.MODERATOR);
            var isAdminRoleExists = await _roleManager.RoleExistsAsync(StaticUserRoles.ADMIN);
            var isUserRoleExists = await _roleManager.RoleExistsAsync(StaticUserRoles.CUSTOMER);

            if (isOwnerRoleExists && isAdminRoleExists && isUserRoleExists)
                return new AuthResponse
                {
                    IsSucceed = true,
                    Token = "Roles Seeding is Already Done"
                };

            await _roleManager.CreateAsync(new IdentityRole(StaticUserRoles.CUSTOMER));
            await _roleManager.CreateAsync(new IdentityRole(StaticUserRoles.ADMIN));
            await _roleManager.CreateAsync(new IdentityRole(StaticUserRoles.MODERATOR));

            return new AuthResponse
            {
                IsSucceed = true,
                Token = "Role Seeding Done Successfully"
            };
        }
    }
}
