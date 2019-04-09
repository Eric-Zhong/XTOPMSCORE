﻿//
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

namespace XTOPMS.Dto
{
    public class XTOPMSEntityDto<T> : FullAuditedEntityDto<T>
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
    }
}
