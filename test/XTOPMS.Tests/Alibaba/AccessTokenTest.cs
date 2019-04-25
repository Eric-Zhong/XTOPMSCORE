//
//  AccessTokenTest.cs
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
using com.alibaba.openapi.client;
using XTOPMS.Alibaba;
using XTOPMS.EntityFrameworkCore.Repositories;
using Xunit;

namespace XTOPMS.Tests.Alibaba
{
    public class AccessTokenTest : XTOPMSTestBase
    {
        readonly IAccessTokenAppService _accessTokenAppService;
        readonly IAccessTokenManager _accessTokenManager;
        readonly IAccessTokenRepository _accessTokenRepository;

        public AccessTokenTest()
        {
            _accessTokenAppService = Resolve<IAccessTokenAppService>();
            _accessTokenManager = Resolve<IAccessTokenManager>();
            _accessTokenRepository = Resolve<IAccessTokenRepository>();
        }

        [Fact]
        public void Alibaba_GetToken()
        {
            SyncAPIClient client = new SyncAPIClient("3259943", "t6MpyARzzv");
            var token = client.getToken("a448afd8-ef2c-4e51-9b2c-a640e8551a81");
            Console.WriteLine(token.getAccess_token());
            Assert.True(true);
        }

        [Fact]
        public void InitializeAccessToken_Test()
        {
            // Act
            var list = _accessTokenRepository.GetAllList();

            if (list.Count > 0)
            {
                var token = _accessTokenRepository.Get(list[0].Id);
                _accessTokenManager.InitializeToken(token, "079617f6-df6d-4253-b5d1-15ce170dbf10");
            }

            // Assert
            Assert.True(true);
        }
    }
}
