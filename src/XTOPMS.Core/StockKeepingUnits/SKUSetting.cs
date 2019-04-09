//
//  SKUSetting.cs
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
using Abp.Domain.Repositories;

namespace XTOPMS.StockKeepingUnits
{
    public class SKUSetting: XTOPMSEntity
    {
        public long SkuId { get; set; }
        public long SkuCategoryId { get; set; }
        public long SkuCategoryValueId { get; set; }
        public bool IsCustomize { get; set; }
        [StringLength(255)]
        public string CustomizeName { get; set; }
        [StringLength(255)]
        public string CustomizeSetting { get; set; }

        public SKUSetting()
        {
        }
    }




    public interface ISKUSettingRepository : IRepository<SKUSetting, long>
    {
    }


}
