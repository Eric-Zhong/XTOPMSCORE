﻿//
//  AccessToken.cs
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
using Abp.EntityFrameworkCore;
using XTOPMS.Alibaba;
using System.Linq;
using Abp.Linq.Extensions;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IAccessTokenRepository 
        : IXTOPMSRepositoryWithAuditedBase<AccessToken, long>
    {
        Task<List<AccessToken>> GetAllRefreshTokenWillTimeout();
        Task<List<AccessToken>> GetAllAccessTokenWillTimeout();
    }


    public class AccessTokenRepository 
        : XTOPMSRepositoryWithAuditedBase<AccessToken,long>
        , IAccessTokenRepository
    {
        public AccessTokenRepository(IDbContextProvider<XTOPMSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// Get all token, that have need to refresh the "refresh token".
        /// </summary>
        /// <returns>The all need refresh.</returns>
        public async Task<List<AccessToken>> GetAllRefreshTokenWillTimeout()
        {
            var query = from m in this.GetAll()
                        where 
                            m.Refresh_Token_Timeout.AddDays(-30) <= DateTime.Now 
                            && m.IsActive == true
                            && m.IsDeleted == false
                        select m
                        ;

            var list = await Task.FromResult(query.ToList());

            return list;
        }


        /// <summary>
        /// Get all access token that have to update.
        /// </summary>
        /// <returns>The all access token will timeout.</returns>
        public async Task<List<AccessToken>> GetAllAccessTokenWillTimeout()
        {
            var query = from m in this.GetAll()
                        where 
                            m.Expires_In.AddHours(-1) <= DateTime.Now
                            && m.IsActive == true
                            && m.IsDeleted == false
                        select m
                        ;

            var list = await Task.FromResult(query.ToList());

            return list;
        }
    }

}
