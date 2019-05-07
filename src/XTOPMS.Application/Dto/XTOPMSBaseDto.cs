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
    /// 继承：IEntityDto
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：定义 Get 的输出 DTO 参数, Create, Update 时的输入 DTO 参数
    /// 说明：不含 FullAudited, Tenancy, IsActive, IsDelete, OrganizationUnit 信息
    /// </summary>
    public interface IXTOPMSBaseDto
        : IXTOPMSBaseDto<long>
    {
    }

    /// <summary>
    /// XTOPMS 中用于定义 Create, Update 输入参数的基类。
    /// 继承：IEntityDto
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：定义 Get 的输出 DTO 参数, Create, Update 时的输入 DTO 参数
    /// 说明：不含 FullAudited, Tenancy, IsActive, IsDelete, OrganizationUnit 信息
    /// </summary>
    public interface IXTOPMSBaseDto<TPrimaryKey>
        : IEntityDto<TPrimaryKey>
    {
        string Key { get; }
        string Name { get; set; }
        string Code { get; set; }
        string ErpId { get; set; }
        int Status { get; set; }
        string Comment { get; set; }
    }



    /// <summary>
    /// XTOPMS 中用于定义 Create, Update 输入参数的基类。
    /// 字段：Id, Key(id), Name, Code, ErpId, Status, Comment, IsActive, ExtensionData 信息
    /// 用途：定义 Get 的输出 DTO 参数, Create, Update 时的输入 DTO 参数
    /// 说明：不含 FullAudited, Tenancy, IsActive, IsDelete, OrganizationUnit 信息
    /// </summary>
    public class XTOPMSBaseDto
        : XTOPMSBaseDto<long>
    {
    }

    public class XTOPMSBaseDto<TPrimaryKey>
        : EntityDto<TPrimaryKey>
        , IXTOPMSBaseDto<TPrimaryKey>
    {
        public string Key
        {
            get
            {
                return this.Id.ToString();
            }
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string ErpId { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }

        public XTOPMSBaseDto() : base()
        {
        }
    }


}
