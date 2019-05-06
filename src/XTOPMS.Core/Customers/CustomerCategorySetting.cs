//
//  CustomerCategorySetting.cs
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
using System.ComponentModel.DataAnnotations.Schema;
using XTOPMS.Metadata;

namespace XTOPMS.Customers
{
    public interface ICustomerCategorySetting<TCustomer, TCustomerCategory>
    {
        long CustomerId { get; set; }
        long CustomerCategoryId { get; set; }
        TCustomer Customer { get; set; }
        TCustomerCategory CustomerCategory { get; set; }
    }

    [Table("XTOPMS_CustomerCategorySetting")]
    public class CustomerCategorySetting: XTOPMSEntity<long>, ICustomerCategorySetting<Customer, CustomerCategory>
    {
        public CustomerCategorySetting()
        {
        }

        public long CustomerId { get; set; }
        public long CustomerCategoryId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("CustomerCategoryId")]
        public CustomerCategory CustomerCategory { get; set; }

        [NotMapped]
        public string CategoryName
        {
            get
            {
                return this.CustomerCategory != null ? this.CustomerCategory.Name : null;
            }
        }

        [NotMapped]
        public string CategoryCode
        {
            get
            {
                return this.CustomerCategory != null ? this.CustomerCategory.Code : null;
            }
        }
    }
}