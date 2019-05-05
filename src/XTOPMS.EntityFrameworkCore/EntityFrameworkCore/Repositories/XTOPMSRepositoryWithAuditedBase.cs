using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Extensions;
using Abp.EntityFrameworkCore.Repositories;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IXTOPMSRepositoryWithAuditedBase<TEntity>
        : IXTOPMSRepositoryWithAuditedBase<TEntity, long>
        where TEntity : class, IXTOPMSEntity, IEntity<long>
    {

    }

    public interface IXTOPMSRepositoryWithAuditedBase<TEntity, TPrimaryKey>
        : IXTOPMSRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : class, IXTOPMSEntity, IEntity<TPrimaryKey>
    {
        // Add your methods.
        TEntity GetDetailV1(TPrimaryKey id);
        Task<TEntity> GetDetailV1Async(TPrimaryKey id);
    }



    public abstract class XTOPMSRepositoryWithAuditedBase<TEntity>
        : XTOPMSRepositoryWithAuditedBase<TEntity, long>
        where TEntity : class, IXTOPMSEntity, IEntity<long>
    {
        protected XTOPMSRepositoryWithAuditedBase(IDbContextProvider<XTOPMSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }


    public abstract class XTOPMSRepositoryWithAuditedBase<TEntity, TPrimaryKey>
        : XTOPMSRepositoryBase<TEntity, TPrimaryKey>
        , IXTOPMSRepositoryWithAuditedBase<TEntity, TPrimaryKey>
        where TEntity: class, IXTOPMSEntity, IEntity<TPrimaryKey>
    {
        protected XTOPMSRepositoryWithAuditedBase(IDbContextProvider<XTOPMSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }


        public TEntity GetDetailV1(TPrimaryKey id)
        {
            
            var query = this.GetAll();

            query = query.IncludeIf(true, t => t.CreatorUser);
            query = query.IncludeIf(true, t => t.DeleterUser);
            query = query.IncludeIf(true, t => t.LastModifierUser);

            var output = query.FirstOrDefault(base.CreateEqualityExpressionForId(id));

            return output;
        }

        public Task<TEntity> GetDetailV1Async(TPrimaryKey id)
        {
            return Task.FromResult(this.GetDetailV1(id));
        }

        // Add your methods.
    }

}
