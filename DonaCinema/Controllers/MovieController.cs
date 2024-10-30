using DonaCinema.Service.Interface;
using DonaCinema.BusinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using DonaCinema.BusinessObject.Entity;
using DonaCinema.BusinessObject.Models.Request;

namespace DonaCinema.API.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovie(int page = 1, int pageSize = 10, string? searchTerm = null)
        {
            try
            {
                var data = await _movieService.GetAll(page, pageSize, searchTerm);
                if (data == null)
                {
                    return BadRequest(new BaseResponseModel<object>
                    {
                        IsSuccess = false,
                        Message = "No movie found"
                    });
                }
                return Ok(new BaseResponseModel<Movie>
                {
                    IsSuccess = true,
                    Results = data,
                    Message = "Get all movie Successful"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new BaseResponseModel<object>
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovie(Guid id) 
        {
            try
            {
                var data = await _movieService.GetById(id);
                if (data == null)
                {
                    return Ok(new BaseResponseModel<object>
                    {
                        IsSuccess = false,
                        Message = "No movie found"
                    });
                }
                return Ok(new BaseResponseModel<Movie>
                {
                    IsSuccess = true,
                    Result = data,
                    Message = "Get movie Successful"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new BaseResponseModel<object>
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddMovie(MovieRequestModel movie)
        {
            try
            {
                await _movieService.Add(movie);
                return Ok(new BaseResponseModel<object>()
                {
                    IsSuccess = true,
                    Message = "Created succesful"
                });
            }
            catch (Exception ex) 
            {
                return BadRequest(new BaseResponseModel<object>()
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(Guid id,MovieRequestModel movie)
        {
            try
            {
                await _movieService.Update(id, movie);
                return Ok(new BaseResponseModel<object>()
                {
                    IsSuccess = true,
                    Message = "Updated succesful"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new BaseResponseModel<object>()
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(Guid id) 
        {
            try
            {
                await _movieService.Delete(id);
                return Ok(new BaseResponseModel<object>()
                {
                    IsSuccess = true,
                    Message = "Updated succesful"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new BaseResponseModel<object>()
                {
                    IsSuccess = false,
                    Message = ex.Message
                });
            }
        }
    }
}
