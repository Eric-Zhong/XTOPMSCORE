//
//  CustomerDto.cs
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
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using XTOPMS.Dto;

namespace XTOPMS.Customers.Dto
{
    [AutoMap(typeof(Customer))]
    public class CustomerDto : XTOPMSEntityDto<long>
    {
        public string ParentId { get; set; }
        public string CompanyCode { get; set; }
        public string Category { get; set; }
        public string ShortName { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string Person { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string RegionData { get; set; }
        public string Address { get; set; }
        public int Rate { get; set; }
        public string RateReason { get; set; }

        public CustomerKeyFieldDto Parent { get; set; }

        // Get customer's category settings.
        public List<CustomerCategorySettingKeyFieldDto> CustomerCategorySettings { get; set; }
    }
}
