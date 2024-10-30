using DonaCinema.BusinessObject.Contract.UnitOfWorks;
using DonaCinema.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Repository.UnitOfWork;

public interface IUnitOfWork : IBaseUnitOfWork
{
    /*IUserRepository UserRepository { get; }*/
    IMovieRepository MovieRepository { get; }
}
