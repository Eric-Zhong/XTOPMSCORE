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


using Abp.Application.Services.Dto;

namespace XTOPMS.Application.Dto
{
    /// <summary>
    /// XTOPMS 中最基础的 Query DTO，用于与 GetAll 接口配合使用，但无法实现 Filter 功能。只能用于输入参数。
    /// </summary>
    public class PagedSortedFilterRequestBaseDto : PagedAndSortedResultRequestDto, IPagedAndSortedResultRequest
    {
        // Add your property
    }
}
