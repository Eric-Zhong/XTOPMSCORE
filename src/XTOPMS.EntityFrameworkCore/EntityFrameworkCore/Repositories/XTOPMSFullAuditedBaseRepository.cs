using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Collections.Extensions;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IXTOPMSFullAuditedBaseRepository<TEntity>
        : IXTOPMSFullAuditedBaseRepository<TEntity, long>
        where TEntity : class, IXTOPMSEntity, IEntity<long>
    {

    }

    public interface IXTOPMSFullAuditedBaseRepository<TEntity, TPrimaryKey>
        : IXTOPMSBaseRepository<TEntity, TPrimaryKey>
        where TEntity : class, IXTOPMSEntity, IEntity<TPrimaryKey>
    {
        // Add your methods.
        TEntity GetDetailV1(TPrimaryKey id);
        Task<TEntity> GetDetailV1Async(TPrimaryKey id);
    }



    public abstract class XTOPMSFullAuditedBaseRepository<TEntity>
        : XTOPMSFullAuditedBaseRepository<TEntity, long>
        where TEntity : class, IXTOPMSEntity, IEntity<long>
    {
        protected XTOPMSFullAuditedBaseRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }


    public abstract class XTOPMSFullAuditedBaseRepository<TEntity, TPrimaryKey>
        : XTOPMSBaseRepository<TEntity, TPrimaryKey>
        , IXTOPMSFullAuditedBaseRepository<TEntity, TPrimaryKey>
        where TEntity: class, IXTOPMSEntity, IEntity<TPrimaryKey>
    {
        protected XTOPMSFullAuditedBaseRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }


        public override IQueryable<TEntity> GetAll()
        {
            return this.GetAllIncluding();
        }

        /// <summary>
        /// Gets all including. Default with creator and modifier.
        /// </summary>
        /// <returns>The all including.</returns>
        /// <param name="propertySelectors">Property selectors.</param>
        public override IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            //propertySelectors.AddIfNotContains(t => t.CreatorUser);
            //propertySelectors.AddIfNotContains(t => t.LastModifierUser);

            var query = base.GetAllIncluding(propertySelectors);
            query = query.Include(t => t.CreatorUser).Include(t => t.LastModifierUser);

            return query;
        }

        public virtual IQueryable<TEntity> GetDetailIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            var query = this.GetAll();
            if (!propertySelectors.IsNullOrEmpty())
            {
                foreach (var propertySelector in propertySelectors)
                {
                    query = query.Include(propertySelector);
                }
            }
            return query;
        }

        public virtual TEntity GetDetailV1(TPrimaryKey id)
        {

            var query = this.GetDetailIncluding(
                t => t.DeleterUser
                );

            //query = query.IncludeIf(true, t => t.CreatorUser);
            //query = query.IncludeIf(true, t => t.DeleterUser);
            //query = query.IncludeIf(true, t => t.LastModifierUser);

            var output = query.FirstOrDefault(base.CreateEqualityExpressionForId(id));

            return output;
        }

        public virtual Task<TEntity> GetDetailV1Async(TPrimaryKey id)
        {
            return Task.FromResult(this.GetDetailV1(id));
        }

        // Add your methods.
    }

}
