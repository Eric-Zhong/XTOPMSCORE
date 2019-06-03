//
//  AlibabaProductCategoryAppService.cs
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
using System.Linq;
using Abp.Linq.Extensions;
using XTOPMS.Alibaba.Dto;
using XTOPMS.Application.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{
    public interface IAlibabaProductCategoryAppService
        : IXTOPMSAsyncCrudAppService<
            ProductCategoryDto,
            long,
            QueryBaseDto,
            ProductCategoryCreateUpdateDto,
            ProductCategoryCreateUpdateDto,
            ProductCategoryCreateUpdateDto,
            ProductCategoryCreateUpdateDto>
    {

    }

    public class AlibabaProductCategoryAppService
        : XTOPMSAsyncCrudAppService<
            ProductCategory, 
            ProductCategoryDto,
            long,
            QueryBaseDto,
            ProductCategoryCreateUpdateDto,
            ProductCategoryCreateUpdateDto,
            ProductCategoryCreateUpdateDto,
            ProductCategoryCreateUpdateDto>
    {
        public AlibabaProductCategoryAppService(IAlibabaProductCategoryRepository repository) : base(repository)
        {
        }

        protected override IQueryable<ProductCategory> CreateFilteredQuery(QueryBaseDto input)
        {
            var query = base.CreateFilteredQuery(input);

            if (input.Filters != null)
            {
                var filter = input.Filters;
                query = query.WhereIf(filter.IsActive.Count > 0 && filter.IsActive[0] == true, t => t.IsActive);
                query = query.WhereIf(filter.IsActive.Count > 0 && filter.IsActive[0] == false, t => !t.IsActive);
            }

            return query;
        }

    }
}
