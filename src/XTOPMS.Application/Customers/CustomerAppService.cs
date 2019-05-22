//
//  CustomerAppService.cs
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
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Abp.Auditing;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.EntityFrameworkCore.Extensions;
using XTOPMS.Authorization;
using XTOPMS.Customers.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;
using XTOPMS.Application.Dto;
using Abp.Application.Services;
using Abp.Linq.Extensions;
using XTOPMS.Dto;

namespace XTOPMS.Customers
{

    /// <summary>
    /// Customer app service interface.
    /// </summary>
    public interface ICustomerAppService: IApplicationService
    {
        Task<List<CustomerSearchResultDto>> Search(CustomerSearchInputDto input);
    }

    [Audited]
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class CustomerAppService :
        XTOPMSAsyncCrudAppService<
            Customer,
            CustomerDto,
            long,
            CustomerQueryDto,
            CustomerUpdateDto,
            CustomerUpdateDto,
            EntityDto<long>,
            EntityDto<long>
            >,
        ICustomerAppService
    {
        private ICustomerRepository repository;
        private ICustomerManager customerManager;

        public CustomerAppService(
            ICustomerRepository _repository
            , ICustomerManager _customerManager
            ) : base(_repository)
        {
            this.CreatePermissionName = PermissionNames.API_Customer_Create;
            this.GetAllPermissionName = PermissionNames.API_Customer_GetAll;
            this.GetPermissionName = PermissionNames.API_Customer_Get;
            this.UpdatePermissionName = PermissionNames.API_Customer_Update;
            repository = _repository;
            customerManager = _customerManager;
        }

        protected override IQueryable<Customer> CreateFilteredQuery(CustomerQueryDto input)
        {
            var query = base.CreateFilteredQuery(input);
            query = query
                .WhereIf(input.Filters != null && input.Filters.Rate != null, t => input.Filters.Rate.Contains(t.Rate))
                // 下面这种写法，后台翻译后变成了 FALSE = TRUE 肯本查不出数据
                // .WhereIf(input.Filters != null && input.Filters.IsActive != null && input.Filters.IsActive.Count > 0, t => t.IsActive == input.Filters.IsActive[0])
                ;
            if(input.Filters != null && input.Filters.IsActive != null && input.Filters.IsActive.Count > 0)
            {
                if (input.Filters.IsActive[0]) // True
                {
                    query = query.Where(t => t.IsActive);
                }
                else // False
                {
                    query = query.Where(t => !t.IsActive);
                }
            }
            query = query.IncludeIf(true, "CustomerCategorySettings.CustomerCategory");
            return query;
        }


        public override async Task<List<CustomerDto>> QuickSearch(QuickSearchInputDto input)
        {
            var value = input.Value;
            var count = input.Count;

            var query = Repository.GetAll();

            query = query.Where(t =>
                (t.Name ?? "").Contains(value) ||
                (t.Code ?? "").Contains(value) ||
                (t.ErpId ?? "").Contains(value)
                );

            query = query.Take(count);
            query = query.OrderBy(t => t.Name);

            var list = await Task.FromResult(query.ToList());

            var items = ObjectMapper.Map<List<CustomerDto>>(list);

            return items;
        }

        public async Task<List<CustomerSearchResultDto>> Search(CustomerSearchInputDto input)
        {
            var value = input.Value;
            var count = input.Count;

            if (count > 200) count = 200;

            var query = from user in this.repository.GetAll()
                        where
                            (user.Name ?? "").Contains(value) ||
                            (user.ShortName ?? "").Contains(value) ||
                            (user.CompanyCode ?? "").Contains(value) ||
                            (user.Code ?? "").Contains(value) ||
                            (user.ErpId ?? "").Contains(value)
                        select user; 

            query = query.Take(count);
            query = query.OrderBy(t => t.Name);

            var list = await Task.FromResult(query.ToList());
            var items = ObjectMapper.Map<List<CustomerSearchResultDto>>(list);
            return items;
        }

        public override async Task<CustomerDto> Update(CustomerUpdateDto input)
        {
            customerManager.UpdateCustomerCategory(input.Id, input.CategorySettings);
            var output = await base.Update(input);
            return output;
        }
    }
}
