using DonaCinema.BusinessObject.Contract.Repositories;
using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Contract.UnitOfWorks;

    public interface IBaseUnitOfWork : IDisposable
    {
        IBaseRepository<TEntity> GetRepositoryByEntity<TEntity>() where TEntity : BaseEntity;

        TRepository GetRepository<TRepository>() where TRepository : IBaseRepository;

        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
