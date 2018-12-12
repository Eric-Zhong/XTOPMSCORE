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
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

namespace XTOPMS
{
    public class XTOPMSEntity : FullAuditedEntity<long>, IMayHaveTenant, IMayHaveOrganizationUnit, IExtendableObject, IPassivable
    {
        public long? OrganizationUnitId { get; set; }
        public int? TenantId { get; set; }
        public string ExtensionData { get; set; }
        public bool IsActive { get; set; }

        // Common property
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string Code { get; set; }
        [StringLength(256)]
        public string ErpId { get; set; }

        public XTOPMSEntity()
        {
        }

    }
}
