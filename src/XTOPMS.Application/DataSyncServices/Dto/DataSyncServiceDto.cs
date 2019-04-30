//
//  DataSyncServiceDto.cs
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
using Abp.AutoMapper;
using XTOPMS.Dto;

namespace XTOPMS.DataSyncServices.Dto
{
    [AutoMap(typeof(DataSyncService))]
    public class DataSyncServiceDto: XTOPMSEntityDto<long>
    {

        /// <summary>
        /// Gets or sets the access token identifier.
        /// </summary>
        /// <value>The access token identifier.</value>
        public long AccessTokenId { get; set; }

        /// <summary>
        /// 上次运行的时间
        /// </summary>
        /// <value>The latest run time.</value>
        public DateTime LastRunTime { get; set; }

        /// <summary>
        /// 下次运行的时间
        /// </summary>
        /// <value>The next run time.</value>
        public DateTime NextRunTime { get; set; }

        /// <summary>
        /// 延时周期（单位：分钟）
        /// </summary>
        /// <value>The indivadue.</value>
        public double Interval { get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        /// <value>The retry count.</value>
        public int RetryCount { get; set; }

        public string LastResult { get; set; }
    }
}
