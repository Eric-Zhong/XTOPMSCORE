﻿//
//  CustomerCategory.cs
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
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XTOPMS.Customers;

namespace XTOPMS.Metadata
{
    public interface ICustomerCategory: IXTOPMSEntity
    {
        List<CustomerCategorySetting> CustomerCategorySettings { get; set; }
    }

    [Table("XTOPMS_CustomerCategory")]
    public class CustomerCategory: XTOPMSEntity, ICustomerCategory
    {
        public CustomerCategory()
        {
        }

        public virtual List<CustomerCategorySetting> CustomerCategorySettings { get; set; }
    }

}
