在这个目录下定义业务实体类与数据库交互的方法的具体实现

···
using System;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using XTOPMS.Entities;
using XTOPMS.Repositories;

namespace XTOPMS.EntityFrameworkCore.Repositories
{
    public class OpportunityRepository: XTOPMSRepositoryBase<Opportunity, long>, IOpportunityRepository
    {
        public OpportunityRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider): base(dbContextProvider)
        {
        }
    }
}
···