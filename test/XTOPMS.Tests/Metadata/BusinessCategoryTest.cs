//
//  BusinessCategoryTest.cs
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
using XTOPMS.EntityFrameworkCore.Repositories;
using System.Linq;
using Xunit;

namespace XTOPMS.Tests.Metadata
{
    public class BusinessCategoryTest: XTOPMSTestBase
    {

        IBusinessCategoryRepository businessCategoryRepository;

        public BusinessCategoryTest(): base()
        {
            businessCategoryRepository = Resolve<IBusinessCategoryRepository>();
            Console.WriteLine(businessCategoryRepository.Count());
        }


        [Fact]
        public void Initialize_ParentId()
        {
            var query = from m in this.businessCategoryRepository.GetAll()
                        select m;

            var list = query.ToList();

            foreach(var item in list)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(list.Count.ToString());
        }
    }
}
