﻿//
//  BusinessCategoryDto.cs
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
using Abp.AutoMapper;
using XTOPMS.Dto;

namespace XTOPMS.Metadata.BusinessCategories
{
    [AutoMap(typeof(BusinessCategory))]
    public class BusinessCategoryBaseDto : XTOPMSBaseDto<string>
    {
        public string ParentId { get; set; }
        public string FullKey { get; set; }
        public string FullPath { get; set; }
        public int Level { get; set; }
        public bool IsLeaf { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }

        public BusinessCategoryBaseDto(): base()
        {
        }
    }
}
