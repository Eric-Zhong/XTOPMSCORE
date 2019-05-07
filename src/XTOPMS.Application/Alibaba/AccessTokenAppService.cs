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
using Abp.Application.Services.Dto;
using Abp.Domain.Uow;

namespace XTOPMS.Alibaba
{

    public interface IAccessTokenAppService: IApplicationService
    {
        Task<AccessTokenDto> InitializeAccessToken(InitializeAccessTokenInputDto input);
    }


    /// <summary>
    /// Access Token Application Service
    /// </summary>
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class AccessTokenAppService : 
        XTOPMSAsyncCrudAppService<AccessToken, AccessTokenDto>
        , IAccessTokenAppService
    {

        readonly IAccessTokenManager _accessTokenManager;
        readonly IUnitOfWorkManager _unitOfWorkManager;

        public AccessTokenAppService(
            IAccessTokenRepository repository
            , IAccessTokenManager accessTokenManager
            , IUnitOfWorkManager unitOfWorkManager
            ) : base(repository)
        {
            _accessTokenManager = accessTokenManager;
            _unitOfWorkManager = unitOfWorkManager;
        }


        public override async Task<PagedResultDto<AccessTokenDto>> GetAll(PagedAndSortedResultRequestDto input)
        {
            using(_unitOfWorkManager.Current.DisableFilter(AbpDataFilters.SoftDelete))
            {
                var result = await base.GetAll(input);
                return result;
            }
        }


        public override async Task<AccessTokenDto> Update(AccessTokenDto input)
        {
            using (_unitOfWorkManager.Current.DisableFilter(AbpDataFilters.SoftDelete))
            {
                return await base.Update(input);
            }
        }


        public async Task<AccessTokenDto> InitializeAccessToken(InitializeAccessTokenInputDto input)
        {
            // AccessToken token = _accessTokenRepository
            AccessToken token = await this.Repository.GetAsync(input.AccessTokenId);

            try
            {
                _accessTokenManager.InitializeToken(token, input.Code);

                var output = MapToEntityDto(token);
                return output;
            }
            catch (OceanException oceanError)
            {
                throw new UserFriendlyException(
                    oceanError.getError_code(),
                    oceanError.getError_message(),
                    oceanError
                    );
            }
            catch (Exception exc)
            {
                throw new UserFriendlyException(
                    exc.Message,
                    exc.ToString(),
                    exc
                    );
            }
        }
    }
}
