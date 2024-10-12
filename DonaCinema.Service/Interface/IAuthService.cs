using DonaCinema.BusinessObject.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Service.Interface
{
    public interface IAuthService
    {
        Task<AuthResponse> SeedRolesAsync();
    }
}
