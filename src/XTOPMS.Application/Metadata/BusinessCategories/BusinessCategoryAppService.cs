//
//  BusinessCategoryAppService.cs
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
using System.Collections;
using System.Collections.Generic;
using Abp.Application.Services;
using XTOPMS.EntityFrameworkCore.Repositories;
using System.Linq;

namespace XTOPMS.Metadata.BusinessCategories
{

    public interface IBusinessCategoryAppService
        : IApplicationService
    {
        List<BusinessCategoryDto> GetAll();
    }


    public class BusinessCategoryAppService
        : XTOPMSAppServiceBase
        , IBusinessCategoryAppService
    {
        IBusinessCategoryRepository businessCategoryRepository;

        public BusinessCategoryAppService(
            IBusinessCategoryRepository _businessCategoryRepository
            )
        {
            businessCategoryRepository = _businessCategoryRepository;
        }

        public List<BusinessCategoryDto> GetAll()
        {

            var list = this.businessCategoryRepository.GetAllIncluding(t=>t.Parent).ToList();

            foreach(var item in list)
            {
                string id = item.Id;
                var arr = id.LastIndexOf('.');
                if (arr <= 0)
                {
                    item.ParentId = null;
                    item.FullPath = item.Name;
                    item.FullKey = item.Id;
                }
                else
                {
                    item.ParentId = id.Substring(0, arr);
                }

                this.businessCategoryRepository.Update(item);
            }

            // var k = this.businessCategoryRepository.GetAll().Take(10).ToList();


            return new List<BusinessCategoryDto>();

        }


    }
}
