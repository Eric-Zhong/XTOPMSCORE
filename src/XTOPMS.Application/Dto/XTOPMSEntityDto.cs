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
using Abp.Domain.Entities.Auditing;
using XTOPMS.Users.Dto;

namespace XTOPMS.Dto
{

    public class XTOPMSEntityDto : XTOPMSEntityDto<long, UserKeyFieldDto>
    {
    }

    public class XTOPMSEntityDto<TPrimaryKey> : XTOPMSEntityDto<TPrimaryKey, UserKeyFieldDto>
    {
    }

    public class XTOPMSEntityDto<TPrimaryKey, TUser> : FullAuditedEntityDto<TPrimaryKey>, IXTOPMSEntityDto<TUser>
    {
        /// <summary>
        /// 为了解决浏览器上会把long数据进行截断，这里把Id转成String然后传递给前台。
        /// </summary>
        /// <value>The key.</value>
        public string key { get { return Id.ToString(); } }
        public int? OrganizationUnitId { get; set; }
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


    public interface IXTOPMSEntityDto<TUser> : IFullAudited
    {
        string key { get; }
        int? OrganizationUnitId { get; set; }
        int? TenantId { get; set; }
        string ExtensionData { get; set; }
        bool IsActive { get; set; }
        string Name { get; set; }
        string Code { get; set; }
        string ErpId { get; set; }
        int Status { get; set; }
        string Comment { get; set; }
        TUser CreatorUser { get; set; }
        TUser LastModifierUser { get; set; }
        TUser DeleterUser { get; set; }
    }
}
