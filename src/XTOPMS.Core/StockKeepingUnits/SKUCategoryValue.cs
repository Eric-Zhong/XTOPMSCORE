//
//  SKUCategoryValue.cs
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
    [Table("XTOPMS_SKUCategoryValue")]
    public class SKUCategoryValue: XTOPMSEntity
    {
        [StringLength(255)]
        public string WBS { get; set; }
        public long SkuCategoryId { get; set; }

        public SKUCategoryValue()
        {
        }
    }





    public interface ISKUCategoryValueRepository : IRepository<SKUCategoryValue, long>
    {
    }


}
