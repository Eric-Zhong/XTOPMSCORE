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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using XTOPMS.Authorization;
using XTOPMS.Customers.Dto;
using System.Linq;
using Abp.Linq.Extensions;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Customers
{

    /// <summary>
    /// Customer app service interface.
    /// </summary>
    public interface ICustomerAppService
    {
        Task<List<CustomerSearchResultDto>> Search(CustomerSearchInputDto input);
    }


    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class CustomerAppService :
        XTOPMSAsyncCrudAppService<
            Customer,
            CustomerDto,
            long
            >,
        ICustomerAppService
    {
        private ICustomerRepository repository;

        public CustomerAppService(
            ICustomerRepository _repository
            ) : base(_repository)
        {
            this.CreatePermissionName = PermissionNames.API_Customer_Create;
            this.GetAllPermissionName = PermissionNames.API_Customer_GetAll;
            this.GetPermissionName = PermissionNames.API_Customer_Get;
            this.UpdatePermissionName = PermissionNames.API_Customer_Update;

            repository = _repository;
        }


        public async Task<List<CustomerSearchResultDto>> Search(CustomerSearchInputDto input)
        {
            var value = input.Value;
            var count = input.Count;

            if (count > 200) count = 200;

            var query = from user in this.repository.GetAll()
                        where
                            user.Name.Contains(value) ||
                            user.ShortName.Contains(value) ||
                            user.CompanyCode.Contains(value) ||
                            user.Code.Contains(value) ||
                            user.ErpId.Contains(value)
                        select user; 

            query = query.Take(count);
            query = query.OrderBy(t => t.Name);

            var list = await Task.FromResult(query.ToList());
            var items = ObjectMapper.Map<List<CustomerSearchResultDto>>(list);
            return items;
        }

    }
}
