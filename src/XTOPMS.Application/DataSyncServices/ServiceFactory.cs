//
//  ServiceFactory.cs
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
using XTOPMS.Alibaba;
using XTOPMS.DataSyncServices;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.DataSyncServices
{

    /// <summary>
    /// Service factory.
    /// </summary>
    public sealed class ServiceFactory
    {

        private readonly IAccessTokenRepository accessTokenRepository;
        private readonly ITradeManager tradeManager;

        public ServiceFactory(
            IAccessTokenRepository a1,
            ITradeManager a2
            )
        {
            accessTokenRepository = a1;
            tradeManager = a2;
        }

        public IService Create(IDataSyncService info)
        {
            IService service = null;

            long serviceCode = 0;


            AccessToken token = accessTokenRepository.Get(info.AccessTokenId);

            if (long.TryParse(info.Code, out serviceCode))
            {
                if(token == null)
                {
                    throw new ApplicationException("Token can not found.");
                }
                // continue...
            }
            else
            {
                throw new ApplicationException(serviceCode.ToString() + " service code format was warran");
            }

            switch (serviceCode)
            {
                case (long)DataSyncServiceCode.com_alibaba_trade_alibaba_trade_getSellerOrderList_1:
                    service = new AlibabaTradeGetSellerOrderListService(token, tradeManager);
                    break;
                case (long)DataSyncServiceCode.com_alibaba_trade_alibaba_trade_get_sellerView_1:
                    break;
            }

            return service;
        }
    }
}
