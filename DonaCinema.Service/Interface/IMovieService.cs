using DonaCinema.BusinessObject.Entity;
using DonaCinema.BusinessObject.Models.Request;

namespace DonaCinema.Service.Interface
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAll(int page, int pageSize, string? searchTerm);
        Task<Movie> GetById(Guid id);
        Task Add(MovieRequestModel movie);
        Task Update(Guid id,MovieRequestModel movie);
        Task Delete(Guid id);
    }
}
