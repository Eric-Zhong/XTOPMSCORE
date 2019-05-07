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
    /// XTOPMS 中用于定义 Get, Create, Update 输入、输出参数的 DTO。
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：适用于定义 Get, GetAll 时，输出 Entity 的明细信息
    /// 建议：用在显示 List 信息时使用
    /// 注意：注意 Update 时，TenantId, OrganizationUnitId, IsDeleted, IsActive 等都要赋值，否则数据会丢失
    /// </summary>
    public interface IXTOPMSEntityBaseDto: IXTOPMSEntityBaseDto<long>
    {
    }


    public interface IXTOPMSEntityBaseDto<TPrimaryKey> 
        : IXTOPMSBaseDto<TPrimaryKey>
        , IMustHaveTenant
        , IMayHaveOrganizationUnit
        , IPassivable
        , IExtendableObject
    {
    }

    /// <summary>
    /// XTOPMS 中用于定义 Get, Create, Update 输入、输出参数的 DTO。
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：适用于定义 Get, GetAll 时，输出 Entity 的明细信息
    /// 建议：用在显示 List 信息时使用
    /// 注意：注意 Update 时，TenantId, OrganizationUnitId, IsDeleted, IsActive 等都要赋值，否则数据会丢失
    /// </summary>
    public class XTOPMSEntityBaseDto 
        : XTOPMSEntityBaseDto<long>
    {
    }

    public class XTOPMSEntityBaseDto<TPrimaryKey> 
        : XTOPMSBaseDto<TPrimaryKey>
        , IXTOPMSEntityBaseDto<TPrimaryKey>
    {
        /// <summary>
        /// 为了解决浏览器上会把long数据进行截断，这里把Id转成String然后传递给前台。
        /// </summary>
        /// <value>The key.</value>
        public string ExtensionData { get; set; }
        public bool IsActive { get; set; }
        public long? OrganizationUnitId { get; set; }
        public int TenantId { get; set; }
    }


}
