﻿//
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
using XTOPMS.Dto;

namespace XTOPMS.Alibaba.Dto
{
    [AutoMap(typeof(AccessToken))]
    public class AccessTokenDto: XTOPMSEntityDto<long>
    {
        public string App_Key { get; set; }
        public string App_Secret { get; set; }
        public string AliId { get; set; }
        public string Resource_Owner { get; set; }
        public string MemberId { get; set; }
        public string Access_Token { get; set; }
        public DateTime Expires_In { get; set; }
        public string Refresh_Token { get; set; }
        public DateTime Refresh_Token_Timeout { get; set; }


        public AccessTokenDto()
        {
        }
    }
}