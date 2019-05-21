//
//  PagedAndSortedResultRequestDto.cs
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
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using XTOPMS.Dto;
using XTOPMS.Users.Dto;

namespace XTOPMS.Application.Dto
{

    public interface IQueryBaseDto
        : IQueryBaseDto<QueryBaseOption>
    {
    }

    public interface IQueryBaseDto<TFiltersFields>
        : IPagedAndSortedResultRequest
    {
        TFiltersFields Filters { get; set; }
    }

    /// <summary>
    /// XTOPMS 中最基础的 Query DTO，用于与 GetAll 接口配合使用，但无法实现 Filter 功能。只能用于输入参数。
    /// </summary>
    public class QueryBaseDto
        : QueryBaseDto<QueryBaseOption>
        , IPagedAndSortedResultRequest
        , IQueryBaseDto
    {
    }

    public class QueryBaseDto<TFiltersFields> 
        : PagedAndSortedResultRequestDto
        , IPagedAndSortedResultRequest
        , IQueryBaseDto<TFiltersFields>
    {
        // Add your property
        public TFiltersFields Filters { get; set; }
    }


    /// <summary>
    /// XTOPMS Default Entity Filter Options.
    /// </summary>
    public class QueryBaseOption
    {
        public List<string> Name { get; set; }
        public List<string> Code { get; set; }
        public List<string> ErpId { get; set; }
        public List<int> Status { get; set; }
        public List<string> Comment { get; set; }
        public List<long> Id { get; set; }
        public List<int> TenantId { get; set; }
        public List<long> OrganizationUnitId { get; set; }
        public List<string> ExtensionData { get; set; }
        public List<bool> IsActive { get; set; }
        public List<long> CreatorUserId { get; set; }
        public List<DateTime> CreationTime { get; set; }
        public List<long> LastModifierUserId { get; set; }
        public List<DateTime> LastModificationTime { get; set; }
        public List<long> DeleterUserId { get; set; }
        public List<DateTime> DeletionTime { get; set; }
        public List<bool> IsDeleted { get; set; }
    }

}
