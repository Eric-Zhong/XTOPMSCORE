//
//  XTOPMSEntityDto.cs
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
using XTOPMS.Authorization.Users;
using XTOPMS.Users.Dto;

namespace XTOPMS.Dto
{

    /// <summary>
    /// XTOPMS 中用于定义 Create, Update 输入参数的基类。
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 对象：CreatorUser, LastModiferUser (不初始化 DeletedUser)
    /// 用途：适用于定义 Get, GetAll 时，输出 Entity 的明细信息
    /// 建议：用在显示 Detail 信息时使用
    /// 注意：不能用于 Create, Update 的输入 DTO
    /// </summary>
    public interface IXTOPMSEntityDto
        : IXTOPMSEntityDto<long, UserKeyFieldDto>
    {

    }

    public interface IXTOPMSEntityDto<TPrimaryKey>
        : IXTOPMSEntityDto<TPrimaryKey, UserKeyFieldDto>
    {

    }

    public interface IXTOPMSEntityDto<TPrimaryKey, TUser>
        : IXTOPMSBaseDto<TPrimaryKey>
        , IMayHaveTenant
        , IMayHaveOrganizationUnit
        , IExtendableObject
        , IPassivable
        , ISoftDelete
        , IAudited
        , IDeletionAudited
        where TUser : class
    {
        TUser CreatorUser { get; set; }
        TUser LastModifierUser { get; set; }
        TUser DeleterUser { get; set; }
    }


    /// <summary>
    /// XTOPMS 中用于定义 Create, Update 输入参数的基类。
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 对象：CreatorUser, LastModiferUser (不初始化 DeletedUser)
    /// 用途：适用于定义 Get, GetAll 时，输出 Entity 的明细信息
    /// 建议：用在显示 Detail 信息时使用
    /// 注意：不能用于 Create, Update 的输入 DTO
    /// </summary>
    public class XTOPMSEntityDto 
        : XTOPMSEntityDto<long, UserKeyFieldDto>
        , IXTOPMSEntityDto<long, UserKeyFieldDto>
    {
    }

    public class XTOPMSEntityDto<TPrimaryKey> 
        : XTOPMSEntityDto<TPrimaryKey, UserKeyFieldDto>
        , IXTOPMSEntityDto<TPrimaryKey, UserKeyFieldDto>
    {
    }

    public class XTOPMSEntityDto<TPrimaryKey, TUser>
        : FullAuditedEntityDto<TPrimaryKey>
        , IXTOPMSEntityDto<TPrimaryKey, TUser>
        where TUser: class
    {
        /// <summary>
        /// 为了解决浏览器上会把long数据进行截断，这里把Id转成String然后传递给前台。
        /// </summary>
        /// <value>The key.</value>
        public string Key { get { return Id.ToString(); } }
        public long? OrganizationUnitId { get; set; }
        public int? TenantId { get; set; }
        public string ExtensionData { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ErpId { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public TUser CreatorUser { get; set; }
        public TUser LastModifierUser { get; set; }
        public TUser DeleterUser { get; set; }
    }


}
