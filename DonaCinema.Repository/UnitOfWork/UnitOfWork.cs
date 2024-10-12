using DonaCinema.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.Repository.UnitOfWork;

public class UnitOfWork : BaseUnitOfWork<ApplicationDbContext>, IUnitOfWork
{
    public UnitOfWork(ApplicationDbContext context, IServiceProvider serviceProvider) : base(context, serviceProvider)
    {
    }
    /*public IUserRepository UserRepository => GetRepository<IUserRepository>();*/
    
}

