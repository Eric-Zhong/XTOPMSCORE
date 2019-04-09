﻿//
//  Customer.cs
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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Repositories;

namespace XTOPMS.Customers
{
    [Table("XTOPMS_Customer")]
    public class Customer : XTOPMSEntity
    {
        public long ParentCompanyId { get; set; }
        [StringLength(100)]
        public string CompanyCode { get; set; }
        [StringLength(100)]
        public string ShortName { get; set; }
        [StringLength(1000)]
        public string Category { get; set; }
        [StringLength(255)]
        public string BankName { get; set; }
        [StringLength(100)]
        public string BankAccount { get; set; }
        [StringLength(100)]
        public string Person { get; set; }
        [StringLength(100)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Fax { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(255)]
        public string RegionData { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public int Rate { get; set; }
        [StringLength(255)]
        public string RateReason { get; set; }

        public Customer()
        {
        }
    }

    public interface ICustomerRepository : IRepository<Customer, long>
    {
    }

}
