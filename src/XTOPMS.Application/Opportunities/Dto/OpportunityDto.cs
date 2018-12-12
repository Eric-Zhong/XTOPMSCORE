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
using XTOPMS.Entities;

namespace XTOPMS.Opportunities.Dto
{
    [AutoMapFrom(typeof(Opportunity))]
    public class OpportunityDto : EntityDto<long>
    {

        public string Name { get; set; }
        public long CompanyId { get; set; }
        public long PlantId { get; set; }
        public long SalesId { get; set; }
        public decimal Amount { get; set; }
        public long Currency { get; set; }
        public long Country { get; set; }
        public long Province { get; set; }
        public long City { get; set; }
        public long Region { get; set; }

        public OpportunityDto()
        {
        }
    }
}