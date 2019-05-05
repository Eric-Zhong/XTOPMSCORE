using System.Linq;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Extensions;
using Abp.EntityFrameworkCore.Repositories;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IXTOPMSRepositoryBase<TEntity>
        : IXTOPMSRepositoryBase<TEntity, long>
        where TEntity : class, IEntity<long>
    {

    }

    public interface IXTOPMSRepositoryBase<TEntity, TPrimaryKey>
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
    public abstract class XTOPMSRepositoryBase<TEntity, TPrimaryKey> 
        : EfCoreRepositoryBase<XTOPMSDbContext, TEntity, TPrimaryKey>
        , IXTOPMSRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected XTOPMSRepositoryBase(IDbContextProvider<XTOPMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your methods.
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="XTOPMSRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class XTOPMSRepositoryBase<TEntity> : XTOPMSRepositoryBase<TEntity, long>, IRepository<TEntity, long>
        where TEntity : class, IEntity<long>
    {
        protected XTOPMSRepositoryBase(IDbContextProvider<XTOPMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
