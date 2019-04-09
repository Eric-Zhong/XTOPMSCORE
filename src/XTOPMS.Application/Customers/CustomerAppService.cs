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
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using XTOPMS.Authorization;
using XTOPMS.Customers.Dto;

namespace XTOPMS.Customers
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class CustomerAppService: 
        AsyncCrudAppService<
            Customer, 
            CustomerDto, 
            long
            >
    {
        public CustomerAppService(
            ICustomerRepository _repository
            ): base(_repository)
        {
            // 设置权限检查时用到的权限名称，也可能根本用不上
            /*
            base.CreatePermissionName = PermissionNames.API_Customer_Create;
            base.DeletePermissionName = PermissionNames.API_Customer_Delete;
            base.GetPermissionName = PermissionNames.API_Customer_Get;
            base.GetAllPermissionName = PermissionNames.API_Customer_GetAll;
            base.UpdatePermissionName = PermissionNames.API_Customer_Update;
            */           
        }

        [AbpAuthorize(PermissionNames.API_Customer_Create)]
        public override Task<CustomerDto> Create(CustomerDto input)
        {
            // 如果设置了 IMustHaveTenancy 后，下面两行的代码就不需要了。
            // input.TenantId = AbpSession.TenantId;
            // input.CreatorUserId = AbpSession.UserId;

            return base.Create(input);
        }
    }
}
