using DonaCinema.BusinessObject.Entity;
using DonaCinema.BusinessObject.Models.Request;
using DonaCinema.Repository.Interface;
using DonaCinema.Repository.UnitOfWork;
using DonaCinema.Service.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Service.Service
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _contextAccessor;

        public MovieService(IHttpContextAccessor contextAccessor, IUnitOfWork unitOfWork)
        {
            _contextAccessor = contextAccessor;
            _unitOfWork = unitOfWork;
        }

        public async Task Add(MovieRequestModel request)
        {
            Movie movie = MapToMovie(request);
            await _unitOfWork.GetRepositoryByEntity<Movie>().AddAsync(movie);
        }

        public async Task Delete(Guid id)
        {
            await _unitOfWork.GetRepositoryByEntity<Movie>().DeleteAsync(id);
        }

        public async Task<List<Movie>> GetAll(int page, int pageSize, string? searchTerm)
        {
            return await _unitOfWork.GetRepository<IMovieRepository>().GetAllAsync(page, pageSize, searchTerm);
        }

        public async Task<Movie> GetById(Guid id)
        {
            return await _unitOfWork.GetRepositoryByEntity<Movie>().GetById(id);
        }

        public async Task Update(Guid id, MovieRequestModel request)
        {
            Movie movie = MapToMovie(request);
            movie.Id = id;
            movie.LastUpdatedDate = DateTime.Now;
            await _unitOfWork.GetRepositoryByEntity<Movie>().UpdateAsync(movie);
        }

        private Movie MapToMovie(MovieRequestModel model)
        {
            var currUser = _contextAccessor.HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier).Value ?? "1";
            var currUserName = _contextAccessor.HttpContext?.User.Identity.Name ?? "Admin" ;
            return new Movie
            {
                Cast = model.Cast,  
                Language = model.Language,
                AgeRating = model.AgeRating,
                Title = model.Title,
                Description = model.Description,
                Duration = model.Duration,
                Country = model.Country,
                Genre = model.Genre,
                Code = GenerateUniqueCode(),
                Rating = model.Rating,
                Director = model.Director,
                CreatedBy = currUserName,
                CreatedDate = DateTime.Now,
                LastUpdatedBy = currUserName
            };
        }
        private string GenerateUniqueCode() => Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper();
    }
}
