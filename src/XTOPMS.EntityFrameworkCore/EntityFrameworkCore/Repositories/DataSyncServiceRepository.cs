//
//  DataSyncService.cs
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
using XTOPMS.DataSyncServices;
using Abp.Domain.Uow;

namespace XTOPMS.EntityFrameworkCore.Repositories
{

    public interface IDataSyncServiceRepository
        : IXTOPMSFullAuditedBaseRepository<DataSyncService, long>
    {
        Task<List<DataSyncService>> GetAllNeedStartServices();
        Task<DataSyncService> GetDataServiceInforByCodeAndMemberId(string serviceCode, string memberId);
    }


    public class DataSyncServiceRepository
        : XTOPMSFullAuditedBaseRepository<DataSyncService, long>
        , IDataSyncServiceRepository
    {

        IUnitOfWorkManager unitOfWorkManager;

        public DataSyncServiceRepository(
            IDbContextProvider<XTOPMSDbContext> dbContextProvider,
            IUnitOfWorkManager _unitOfWorkManager)
            : base(dbContextProvider)
        {
            unitOfWorkManager = _unitOfWorkManager;
        }

        /// <summary>
        /// Get all token, that have need to refresh the "refresh token".
        /// </summary>
        /// <returns>The all need refresh.</returns>
        public async Task<List<DataSyncService>> GetAllNeedStartServices()
        {
            var query = from m in this.GetAll()         // GetAll() 已经完成了按 Tenant 的过滤
                        where
                            true
                            // && m.IsDeleted == false
                            && m.IsActive == true       // 激活的
                            && m.LastRunTime <= DateTime.Now
                            && m.NextRunTime.AddMinutes(m.Interval) <= DateTime.Now     // 超时的
                            && m.RetryCount <= 10       // 重试次数
                        select m
                        ;

            var list = await Task.FromResult(query.ToList());

            return list;
        }

        public async Task<DataSyncService> GetDataServiceInforByCodeAndMemberId(string serviceCode, string memberId)
        {
            var query = from m in this.GetAllIncluding(t=>t.AccessTokenInfo)
                        where true
                            && m.IsActive == true       // 激活的
                            && m.ErpId == serviceCode
                            && m.AccessTokenInfo.MemberId == memberId
                        select m;

            var list = await Task.FromResult(query.First());
            return list;
        }
    }

}
