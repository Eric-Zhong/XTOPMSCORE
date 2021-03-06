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
using Abp.Domain.Entities;
using XTOPMS.Dto;

namespace XTOPMS.Alibaba.Dto
{

    public interface IAccessTokenCreateUpateDto
        : IXTOPMSBaseDto
        , IPassivable
        , ISoftDelete // AccessToken 比较特殊，把 Delete 也要显示出来，也可以还原
    {
        string App_Key { get; set; }
        string App_Secret { get; set; }
    }

    /// <summary>
    /// Access token create update dto.
    /// Field: App_Key, App_Secret, IsActive, IsDeleted
    /// </summary>
    [Serializable]
    [AutoMap(typeof(AccessToken))]
    public class AccessTokenCreateUpdateDto 
        : XTOPMSBaseDto
        , IAccessTokenCreateUpateDto
    {
        public string App_Key { get; set; }
        public string App_Secret { get; set; }
        public bool IsDeleted { get; set; }         // Token 比较特殊，把 IsDeleted 也要放开
        public bool IsActive { get; set; }

        public AccessTokenCreateUpdateDto(): base()
        {
            this.IsDeleted = false;
        }
    }
}
