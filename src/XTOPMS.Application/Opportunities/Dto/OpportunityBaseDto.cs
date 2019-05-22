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
using XTOPMS.Users.Dto;

namespace XTOPMS.Opportunities.Dto
{

    public interface IOpportunityBaseDto: IXTOPMSBaseDto
    {
        long? OwnerId { get; set; }
        long? GeneralContractorId { get; set; }
        long? AgencyId { get; set; }
        long? SalesId { get; set; }
        string BusinessCategoryId { get; set; }

        decimal Amount { get; set; }
        string Currency { get; set; }
        string Region { get; set; }
        string Country { get; set; }
        string Province { get; set; }
        string City { get; set; }
        string ScheduleData { get; set; }
        string GeographicData { get; set; }
    }

    [AutoMap(typeof(Opportunity))]
    public class OpportunityBaseDto : XTOPMSEntityDto, IOpportunityBaseDto
    {
        public long? OwnerId { get; set; }
        public long? GeneralContractorId { get; set; }
        public long? AgencyId { get; set; }
        public long? SalesId { get; set; }
        public string BusinessCategoryId { get; set; }

        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string ScheduleData { get; set; }
        public string GeographicData { get; set; }

        public OpportunityBaseDto()
        {
        }
    }
}