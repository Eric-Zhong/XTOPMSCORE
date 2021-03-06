﻿//
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
using Abp.AutoMapper;
using XTOPMS.Customers.Dto;
using XTOPMS.Metadata.BusinessCategories;
using XTOPMS.Users.Dto;

namespace XTOPMS.Opportunities.Dto
{
    [AutoMap(typeof(Opportunity))]
    public class OpportunityDto : OpportunityBaseDto
    {

        public CustomerKeyFieldDto Owner { get; set; }
        public CustomerKeyFieldDto GeneralContractor { get; set; }
        public CustomerKeyFieldDto Agency { get; set; }
        public UserKeyFieldDto Sales { get; set; }
        public BusinessCategoryDto BusinessCategory { get; set; }

        public OpportunityDto(): base()
        {
        }
    }
}