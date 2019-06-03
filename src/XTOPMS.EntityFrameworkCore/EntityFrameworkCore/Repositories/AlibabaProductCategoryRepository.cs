//
//  AlibabaProductCategory.cs
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
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using XTOPMS.Alibaba;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IAlibabaProductCategoryRepository
        : IXTOPMSFullAuditedBaseRepository<ProductCategory>
    {

    }

    public class AlibabaProductCategoryRepository
        : XTOPMSFullAuditedBaseRepository<ProductCategory>
        , IAlibabaProductCategoryRepository
    {
        public AlibabaProductCategoryRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override IQueryable<ProductCategory> GetAll()
        {
            // 用于显示当前可配置的产品货号，不加 Tenant 还不行！
            this.UnitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant, AbpDataFilters.MustHaveTenant);
            return base.GetAll();
        }

    }
}
