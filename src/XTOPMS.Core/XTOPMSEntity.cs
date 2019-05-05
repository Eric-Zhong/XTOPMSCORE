//
//  XTOPMSEntity.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2018 
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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using XTOPMS.Authorization.Users;

namespace XTOPMS
{

    public interface IXTOPMSEntity : IXTOPMSEntity<long, User>
    {
    }

    public interface IXTOPMSEntity<TPrimary> : IXTOPMSEntity<TPrimary, User>
    {
    }

    public interface IXTOPMSEntity<TPrimary, TUser>
        : IFullAudited<TUser>,
        IMustHaveTenant,
        IMayHaveOrganizationUnit,
        IExtendableObject,
        IPassivable
        where TUser : class, IEntity<long>
    {
        string Name { get; set; }
        string Code { get; set; }
        string ErpId { get; set; }
        int Status { get; set; }
        string Comment { get; set; }
    }

    [Serializable]
    public class XTOPMSEntity: XTOPMSEntity<long>
    {
        public XTOPMSEntity(): base()
        {

        }
    }

    [Serializable]
    public class XTOPMSEntity<TPrimaryKey>: 
        FullAuditedEntity<TPrimaryKey, User>,
        IXTOPMSEntity
    {
        public long? OrganizationUnitId { get; set; }
        public int TenantId { get; set; }
        public string ExtensionData { get; set; }
        public bool IsActive { get; set; }

        // Common property

        /// <summary>
        /// 名称
        /// </summary>
        /// <value>The name.</value>
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        /// <value>The code.</value>
        [StringLength(255)]
        public string Code { get; set; }

        /// <summary>
        /// 企业 ERP 中的唯一编号
        /// </summary>
        /// <value>The erp identifier.</value>
        [StringLength(255)]
        public string ErpId { get; set; }

        /// <summary>
        /// 状态标记
        /// </summary>
        /// <value>The status.</value>
        public int Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }


        public XTOPMSEntity(): base()
        {
        }

    }
}
