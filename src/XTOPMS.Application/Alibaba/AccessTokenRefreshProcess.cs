//
//  AccessTokenRefreshProcess.cs
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
using Hangfire.Annotations;
using Hangfire.Server;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{
    public class AccessTokenRefreshProcess: IBackgroundProcess
    {
        private readonly IAccessTokenRepository _accessTokenRepository;
        private readonly IAccessTokenManager _accessTokenManager;

        public AccessTokenRefreshProcess(
            IAccessTokenRepository accessTokenRepository
            , IAccessTokenManager accessTokenManager
            )
        {
            _accessTokenRepository = accessTokenRepository;
            _accessTokenManager = accessTokenManager;
        }

        public void Execute([NotNull] BackgroundProcessContext context)
        {
            Console.WriteLine("Begin to refresh access token background job. " + DateTime.Now.ToString());
            _accessTokenManager.UpdateToken();
            // context.Wait(TimeSpan.FromSeconds(5));
            Console.WriteLine("Finish refresh access token background job. " + DateTime.Now.ToString());
        }
    }
}
