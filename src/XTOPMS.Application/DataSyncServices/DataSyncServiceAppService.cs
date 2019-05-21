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
using System.Linq;
using Abp.Application.Services;
using Abp.Auditing;
using Abp.Authorization;
using Abp.EntityFrameworkCore.Extensions;
using XTOPMS.Alibaba.Dto;
using XTOPMS.Application.Dto;
using XTOPMS.Authorization;
using XTOPMS.DataSyncServices;
using XTOPMS.DataSyncServices.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{

    public interface IDataSyncServiceAppService: IApplicationService
    {
        void Execute(long serviceId);
    }


    /// <summary>
    /// Access Token Application Service
    /// </summary>
    [Audited]
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class DataSyncServiceAppService : 
        XTOPMSAsyncCrudAppService<
            DataSyncService
            , DataSyncServiceDto
            , long
            , QueryBaseDto
            , DataSyncServiceCreateUpdateDto
            , DataSyncServiceCreateUpdateDto
            , DataSyncServiceCreateUpdateDto
            , DataSyncServiceCreateUpdateDto>
        , IDataSyncServiceAppService
    {

        readonly IAccessTokenRepository _accessTokenRepository;
        readonly IAccessTokenManager _accessTokenManager;
        readonly IDataSyncServiceRepository _dataSyncServiceRepository;
        readonly ITradeManager _tradeManager;

        public DataSyncServiceAppService(
            IDataSyncServiceRepository repository
            , IAccessTokenRepository accessTokenRepository
            , IAccessTokenManager accessTokenManager
            , IDataSyncServiceRepository dataSyncServiceRepository
            , ITradeManager tradeManager
            ) : base(repository)
        {
            _accessTokenRepository = accessTokenRepository;
            _accessTokenManager = accessTokenManager;
            _dataSyncServiceRepository = dataSyncServiceRepository;
            _tradeManager = tradeManager;
        }

        protected override IQueryable<DataSyncService> CreateFilteredQuery(QueryBaseDto input)
        {
            var query = base.CreateFilteredQuery(input);
            query = query.IncludeIf(true, t => t.AccessTokenInfo);
            return query;
        }

        public void Execute(long serviceId)
        {
            var syncServiceEntity = _dataSyncServiceRepository.Get(serviceId);
            var accessToken = _accessTokenRepository.Get(syncServiceEntity.AccessTokenId);
            IService service = new AlibabaTradeGetSellerOrderListService(accessToken, _tradeManager);
            service.Execute();
        }
    }
}
