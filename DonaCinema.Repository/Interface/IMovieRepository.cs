using DonaCinema.BusinessObject.Contract.Repositories;
using DonaCinema.BusinessObject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Repository.Interface
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
        Task<List<Movie>> GetAllAsync(int page, int pagesize ,string? searchTerm);
    }
}
