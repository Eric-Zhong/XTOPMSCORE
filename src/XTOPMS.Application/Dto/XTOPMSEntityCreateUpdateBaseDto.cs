//
//  XTOPMSEntityBaseDto.cs
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
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using XTOPMS.Users.Dto;

namespace XTOPMS.Dto
{

    /// <summary>
    /// XTOPMS 中用于定义 Create, Update 输入参数的基类。
    /// 字段：Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：定义 Create, Update 时的输入参数
    /// 注意：Audited, Tenant 信息都会自动赋值
    /// </summary>
    public interface IXTOPMSEntityCreateUpdateBaseDto
        : IXTOPMSBaseDto<long>
    {
        string ExtensionData { get; set; }
        bool IsActive { get; set; }
    }

    /// <summary>
    /// XTOPMS 中用于定义 Create, Update 输入参数的基类。
    /// 字段：Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：定义 Create, Update 时的输入参数
    /// </summary>
    public class XTOPMSEntityCreateUpdateBaseDto
        : XTOPMSEntityCreateUpdateBaseDto<long>
    {
    }

    public class XTOPMSEntityCreateUpdateBaseDto<TPrimaryKey>
        : XTOPMSBaseDto<long>
        , IXTOPMSEntityCreateUpdateBaseDto
    {
        public string ExtensionData { get; set; }
        public bool IsActive { get; set; }
    }


}
