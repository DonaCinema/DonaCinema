﻿using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Contract.Repositories;

    public interface IBaseRepository
    {
    }

    public interface IBaseRepository<TEntity> : IBaseRepository
        where TEntity : BaseEntity
    {
        Task<bool> Check(Guid id);

        IQueryable<TEntity> GetQueryable(CancellationToken cancellationToken = default);

        Task<long> GetTotalCount();

        Task<IList<TEntity>> GetAll(CancellationToken cancellationToken = default);

        Task<TEntity> GetById(Guid id);

        Task<IList<TEntity>> GetByIds(IList<Guid> ids);
        Task AddAsync(TEntity entity);
        Task<bool> DeleteAsync(Guid id);
        Task UpdateAsync(TEntity entity);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
        void CheckCancellationToken(CancellationToken cancellationToken = default);


    }

