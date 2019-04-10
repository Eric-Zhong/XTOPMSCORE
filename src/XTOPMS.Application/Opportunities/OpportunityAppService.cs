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
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using XTOPMS.Authorization;
using XTOPMS.Opportunities.Dto;


namespace XTOPMS.Opportunities
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class OpportunityAppService : AsyncCrudAppService<Opportunity, OpportunityDto, long>
    {

        public OpportunityAppService(
            IOpportunityRepository _repository
        ): base(_repository)
        {
        }


        [AbpAuthorize(PermissionNames.API_Opportunity_Create)]
        public override Task<OpportunityDto> Create(OpportunityDto input)
        {
            return base.Create(input);
        }


        [AbpAuthorize(PermissionNames.API_Opportunity_GetAll)]
        public override Task<PagedResultDto<OpportunityDto>> GetAll(PagedAndSortedResultRequestDto input)
        {
            var result = base.GetAll(input);
            return result;
        }


        [AbpAuthorize(PermissionNames.API_Opportunity_Delete)]
        public override Task Delete(EntityDto<long> input)
        {
            return base.Delete(input);
        }


        [AbpAuthorize(PermissionNames.API_Opportunity_Get)]
        public override Task<OpportunityDto> Get(EntityDto<long> input)
        {
            return base.Get(input);
        }


        [AbpAuthorize(PermissionNames.API_Opportunity_Update)]
        public override Task<OpportunityDto> Update(OpportunityDto input)
        {
            return base.Update(input);
        }


    }
}
