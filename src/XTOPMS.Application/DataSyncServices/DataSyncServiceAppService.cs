//
//  RefreshTokenAppService.cs
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
using Abp.Authorization;
using Abp.Domain.Repositories;
using XTOPMS.Application;
using XTOPMS.Alibaba.Dto;
using XTOPMS.Authorization;
using XTOPMS.EntityFrameworkCore.Repositories;
using Abp.Application.Services;
using com.alibaba.openapi.client.exception;
using Abp.UI;
using XTOPMS.DataSyncServices;
using Abp.Auditing;
using Abp.Application.Services.Dto;

namespace XTOPMS.Alibaba
{

    public interface IDataSyncServiceAppService: IApplicationService
    {

    }


    /// <summary>
    /// Access Token Application Service
    /// </summary>
    [Audited]
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class DataSyncServiceAppService : 
        XTOPMSAsyncCrudAppService<DataSyncService, DataSyncServiceDto>
        , IDataSyncServiceAppService
    {

        readonly IDataSyncServiceRepository _dataSyncServiceRepository;
        readonly IAccessTokenRepository _accessTokenRepository;
        readonly IAccessTokenManager _accessTokenManager;

        public DataSyncServiceAppService(
            IRepository<DataSyncService, long> repository
            , IDataSyncServiceRepository dataSyncServiceRepositor
            , IAccessTokenRepository accessTokenRepository
            , IAccessTokenManager accessTokenManager
            ) : base(repository)
        {
            _dataSyncServiceRepository = dataSyncServiceRepositor;
            _accessTokenRepository = accessTokenRepository;
            _accessTokenManager = accessTokenManager;
        }
    }
}
