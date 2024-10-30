using DonaCinema.BusinessObject.Entity;
using DonaCinema.Repository.Context;
using DonaCinema.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Repository.Repository
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Movie>> GetAllAsync(int page, int pageSize, string? searchTerms)
        {
            var query = GetQueryable()
                        .Where(m => !m.IsDeleted)
                        .AsEnumerable();

            if (searchTerms != null && searchTerms.Any())
            {
                // Thực hiện lọc sau khi đã chuyển sang client
                query = query.Where(m => searchTerms.Any(term => m.Cast.Contains(term)));
            }

            var movies = query.Skip((page - 1) * pageSize)
                             .Take(pageSize)
                             .ToList(); 

            return movies;
        }
    }
}
