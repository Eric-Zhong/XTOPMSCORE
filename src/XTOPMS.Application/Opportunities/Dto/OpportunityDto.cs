//
//  Opportunity.cs
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
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using XTOPMS.Dto;

namespace XTOPMS.Opportunities.Dto
{
    [AutoMap(typeof(Opportunity))]
    public class OpportunityDto : XTOPMSEntityDto<long>
    {
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerShortName { get; set; }
        public long? GeneralContractorId { get; set; }
        public string GeneralContractorName { get; set; }
        public string GeneralContractorShortName { get; set; }
        public long? AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string AgencyShortName { get; set; }
        public long SalesId { get; set; }
        public long SalesName { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string ScheduleData { get; set; }
        public string GeographicData { get; set; }
        public OpportunityDto()
        {
        }
    }
}