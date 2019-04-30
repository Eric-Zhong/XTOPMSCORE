//
//  DataSyncServiceManager.cs
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
using Abp.BackgroundJobs;
using Abp.Domain.Services;
using com.alibaba.openapi.client;
using com.alibaba.openapi.client.policy;
using com.alibaba.trade.param;
using Hangfire;
using XTOPMS.Alibaba;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.DataSyncServices
{

    public interface IDataSyncServiceManager
        : IDomainService
    {
        void UpdateStatusWhenSuccess(DataSyncService service, string message);
        void UpdateStatusWhenFailure(DataSyncService service, string error, Exception exception);
        void Execution();
    }

    public class DataSyncServiceManager
        : DomainService, IDataSyncServiceManager
    {

        private readonly IAccessTokenManager accessTokenManager;
        private readonly IAccessTokenRepository accessTokenRepository;
        private readonly IDataSyncServiceRepository dataSyncServiceRepository;
        private readonly ITradeManager tradeManager;

        public DataSyncServiceManager(
            IAccessTokenManager _accessTokenManager,
            IDataSyncServiceRepository _dataSyncServiceRepository,
            ITradeManager _tradeManager,
            IAccessTokenRepository _accessTokenRepository
            )
        {
            accessTokenManager = _accessTokenManager;
            dataSyncServiceRepository = _dataSyncServiceRepository;
            tradeManager = _tradeManager;
            accessTokenRepository = _accessTokenRepository;
        }

        /// <summary>
        /// 执行完成后更新状态数据
        /// </summary>
        /// <param name="service">Service.</param>
        /// <param name="message">Message.</param>
        public void UpdateStatusWhenSuccess(DataSyncService service, string message)
        {
            service.Status = 1;
            service.RetryCount = 0;
            service.LastResult = message;
            service.LastRunTime = DateTime.Now;
            service.NextRunTime = service.NextRunTime.AddMinutes(service.Interval);
        }

        /// <summary>
        /// Updates the status when failure.
        /// </summary>
        /// <param name="service">Service.</param>
        /// <param name="error">Error.</param>
        /// <param name="exception">Exception.</param>
        public void UpdateStatusWhenFailure(DataSyncService service, string error, Exception exception)
        {
            service.Status = 2;
            service.RetryCount = service.RetryCount + 1;
            service.LastResult = error;
            service.LastRunTime = DateTime.Now;
        }


        /// <summary>
        /// 执行调试服务代码
        /// </summary>
        public void Execution()
        {
            // Get all services need to start
            var list = dataSyncServiceRepository.GetAllNeedStartServices().Result;
            Console.WriteLine("There are " + list.Count + " services need to process.");

            ServiceFactory factory = new ServiceFactory(accessTokenRepository, tradeManager);
             
            // enqueue them to execution queue.
            foreach (var service in list)
            {
                IService serviceJob = factory.Create(service);
                serviceJob.Execute();
                // BackgroundJob.Enqueue(() => Console.WriteLine("Service will start."));
            }

        }
    }
}
