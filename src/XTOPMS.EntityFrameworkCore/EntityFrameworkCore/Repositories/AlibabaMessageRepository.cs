//
//  AlibabaMessageRepository.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using Abp.EntityFrameworkCore;
using XTOPMS.Alibaba;
using System.Linq;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using Abp.Domain.Uow;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IAlibabaMessageRepository
        : IXTOPMSFullAuditedBaseRepository<Message, long>
    {
        List<Message> GetAllMessageNeedToTrigger();
    }

    public class AlibabaMessageRepository
        : XTOPMSFullAuditedBaseRepository<Message, long>
        , IAlibabaMessageRepository
    {
        public AlibabaMessageRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider) 
            : base(dbContextProvider)
        {
        }

        public virtual List<Message> GetAllMessageNeedToTrigger()
        {
            // 因为是后台服务，无法拿到用户信息，这里只能过滤掉 Tenant 功能。
            this.UnitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant, AbpDataFilters.MustHaveTenant);
            var query = from m in this.GetAll()
                        where 
                            m.Status == (int)CallbackMessageStatus.New || 
                            m.Status == (int)CallbackMessageStatus.Resend ||
                            (m.Status == (int)CallbackMessageStatus.Failed && m.RetryCount < 10)
                        select m;

            return query.ToList();
        }

        public override Message Get(long id)
        {
            this.UnitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant, AbpDataFilters.MustHaveTenant);
            return base.Get(id);
        }
    }
}
