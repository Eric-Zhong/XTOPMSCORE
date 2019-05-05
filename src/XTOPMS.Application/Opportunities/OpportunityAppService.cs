//
//  OpportunityAppService.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2018 
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
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore.Extensions;
using XTOPMS.Authorization;
using XTOPMS.EntityFrameworkCore.Repositories;
using XTOPMS.Opportunities.Dto;


namespace XTOPMS.Opportunities
{

    public interface IOpportunityAppService 
    {

    }

    [Audited]
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class OpportunityAppService :
        XTOPMSAsyncCrudAppService<Opportunity, OpportunityDto, long, PagedAndSortedResultRequestDto, OpportunityUpdateDto>
        , IOpportunityAppService
    {

        public OpportunityAppService(
            IOpportunityRepository _repository
        ): base(_repository)
        {
        }

        protected override IQueryable<Opportunity> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            return base.CreateFilteredQuery(input).IncludeIf(true, t=>t.Sales);
        }

    }
}
