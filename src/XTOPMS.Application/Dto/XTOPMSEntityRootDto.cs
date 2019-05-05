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

    public interface IXTOPMSEntityRootDto
        : IEntityDto<long>
    {
        string key { get; }
        string Name { get; set; }
        string Code { get; set; }
    }

    public class XTOPMSEntityRootDto
        : XTOPMSEntityRootDto<long>
    {
    }

    public class XTOPMSEntityRootDto<TPrimaryKey>
        : EntityDto<long>
        , IXTOPMSEntityRootDto
    {
        public string key
        {
            get
            {
                return this.Id.ToString();
            }
        }

        public string Name { get; set; }
        public string Code { get; set; }
    }


}
