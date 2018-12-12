//
//  SKU.cs
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
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Repositories;

namespace XTOPMS.StockKeepingUnits
{
    /// <summary>
    /// SKU of product.
    /// </summary>
    [Table("XTOPMS_SKU")]
    public class SKU: XTOPMSEntity
    {
        public long ProductId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public SKU()
        {
        }
    }


    public interface ISKURepository : IRepository<SKU, long>
    {
    }

}
