//
//  CustomerRepository.cs
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
using System.Linq;
using System.Linq.Expressions;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Extensions;
using XTOPMS.Customers;

namespace XTOPMS.EntityFrameworkCore.Repositories
{
    public interface ICustomerRepository : IXTOPMSFullAuditedBaseRepository<Customer, long>
    {
        void UpdateCategory(long id, List<string> ids);
    }

    public class CustomerRepository : XTOPMSFullAuditedBaseRepository<Customer, long>, ICustomerRepository
    {

        ICustomerCategorySettingRepository customerCategorySettingRepository;

        public CustomerRepository(
            IDbContextProvider<XTOPMSDbContext> dbContextProvider
            , ICustomerCategorySettingRepository _customerCategorySettingRepository
            ) : base(dbContextProvider)
        {
            customerCategorySettingRepository = _customerCategorySettingRepository;
        }

        /// <summary>
        /// Override and generate a new query for get the customer category setting detail data.
        /// </summary>
        /// <returns>The detail including.</returns>
        /// <param name="propertySelectors">Property selectors.</param>
        public override IQueryable<Customer> GetDetailIncluding(params Expression<Func<Customer, object>>[] propertySelectors)
        {
            var query = base.GetDetailIncluding(propertySelectors);
            query = query.IncludeIf(true, t=>t.Parent);
            query = query.IncludeIf(true, "CustomerCategorySettings.CustomerCategory");
            return query;
        }

        public override Customer Update(Customer entity)
        {
            base.Update(entity);
            return this.GetDetailV1(entity.Id);
        }


        public void UpdateCategory(long id, List<string> ids)
        {
            List<long> categoryIds = new List<long>();
            foreach (var key in ids)
            {
                categoryIds.Add(long.Parse(key));
            }

            /* TODO: 验证了一下下面的写法，结果删除上有问题

            // Delete all setting
            customerCategorySettingRepository.Delete(t => t.CustomerId == id);
            // Insert new setting
            foreach(var key in categoryIds)
            {
                customerCategorySettingRepository.Insert(new CustomerCategorySetting
                {
                    CustomerId = id,
                    CustomerCategoryId = key
                });
            }


            // Delete the removed.
            customerCategorySettingRepository.Delete(
                t => t.CustomerId == id 
                && categoryIds.Contains(t.CustomerCategoryId) == false
                );

            // Add new.
            foreach(var key in categoryIds)
            {
                if (customerCategorySettingRepository.Count(t => t.CustomerId == id && t.CustomerCategoryId == key) == 0)
                {
                    customerCategorySettingRepository.Insert(new CustomerCategorySetting
                    {
                        CustomerId = id,
                        CustomerCategoryId = key
                    });
                }
            }

            */


            var list = customerCategorySettingRepository.GetAllList(t => t.CustomerId == id);

            foreach(var item in list)
            {
                if (categoryIds.Contains(item.CustomerCategoryId))
                {
                    categoryIds.Remove(item.CustomerCategoryId);     // 去掉已经存在的
                    continue;
                }
                else
                {
                    customerCategorySettingRepository.Delete(item);
                }
            }

            foreach(var item in categoryIds)
            {
                customerCategorySettingRepository.Insert(new CustomerCategorySetting
                {
                    CustomerId = id,
                    CustomerCategoryId = item
                });
            }


        }
    }
}
