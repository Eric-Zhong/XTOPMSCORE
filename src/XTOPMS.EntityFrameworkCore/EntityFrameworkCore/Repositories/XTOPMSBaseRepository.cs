using System;
using System.Linq;
using System.Linq.Expressions;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Extensions;
using Abp.EntityFrameworkCore.Repositories;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IXTOPMSBaseRepository<TEntity>
        : IXTOPMSBaseRepository<TEntity, long>
        where TEntity : class, IEntity<long>
    {

    }

    public interface IXTOPMSBaseRepository<TEntity, TPrimaryKey>
        : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        // Add your methods.
    }


    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class XTOPMSBaseRepository<TEntity, TPrimaryKey> 
        : EfCoreRepositoryBase<XTOPMSDbContext, TEntity, TPrimaryKey>
        , IXTOPMSBaseRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected XTOPMSBaseRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your methods.
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="XTOPMSBaseRepository{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class XTOPMSBaseRepository<TEntity> : XTOPMSBaseRepository<TEntity, long>, IRepository<TEntity, long>
        where TEntity : class, IEntity<long>
    {
        protected XTOPMSBaseRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
