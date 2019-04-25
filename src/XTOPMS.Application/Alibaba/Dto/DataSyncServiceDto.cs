//
//  AccessTokenDto.cs
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
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Identity;
using XTOPMS.Authorization.Users;
using XTOPMS.Dto;

namespace XTOPMS.Alibaba.Dto
{
    [AutoMap(typeof(DataSyncService))]
    public class DataSyncServiceDto : XTOPMSEntityDto<long>
    {
        public long AccessTokenId { get; set; }
        public DateTime LatestRunTime { get; set; }
        public string LatestResult { get; set; }

        /// <summary>
        /// 通过 code 显示 DataSync 名称
        /// </summary>
        /// <value>The name of the service.</value>
        public string ServiceName {
            get
            {
                string name = Enum.GetName(typeof(DataSyncServiceCode), int.Parse(this.Code));
                return name;
            }
        }

        public string CreatorUserName
        {
            get
            {
                string userName = "";
                if (this.CreatorUserId.HasValue)
                {
                    var user = this._userManager.GetUserByIdAsync(this.CreatorUserId.Value).Result;
                    userName = user.FullName;
                }
                else
                {
                    userName = "";
                }
                return userName;
            }
        }

        private readonly UserManager _userManager;

        public DataSyncServiceDto(
            UserManager userManager
            )
        {
            this._userManager = userManager;
        }


    }
}