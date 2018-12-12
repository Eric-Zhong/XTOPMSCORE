//
//  SKUCategory.cs
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
using Abp.Domain.Repositories;

namespace XTOPMS.StockKeepingUnits
{
    /// <summary>
    /// SKU Category.
    /// </summary>
    [Table("XTOPMS_SKUCategory")]
    public class SKUCategory: XTOPMSEntity
    {
        [StringLength(256)]
        public string WBS { get; set; }
        public long ParentId { get; set; }
        [StringLength(256)]
        public string FullName { get; set; }
        public bool IsSalesProperty { get; set; }
        /// <summary>
        /// Gets or sets the type of the editor. Radio, Text, List
        /// </summary>
        /// <value>The type of the edit.</value>
        [StringLength(50)]
        public string EditType { get; set; }
        public SKUCategory()
        {
        }
    }


    public interface ISKUCategoryRepository : IRepository<SKUCategory, long>
    {
    }

}
