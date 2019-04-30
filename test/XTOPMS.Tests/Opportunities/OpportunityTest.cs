//
//  OpportunityTest.cs
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
using XTOPMS.EntityFrameworkCore.Repositories;
using XTOPMS.Opportunities;
using System.Linq;
using Xunit;

namespace XTOPMS.Tests.Opportunities
{
    public class OpportunityTest: XTOPMSTestBase
    {
        private readonly IOpportunityAppService opportunityAppService;
        private readonly IOpportunityRepository opportunityRepository;
        public OpportunityTest()
        {
            opportunityAppService = Resolve<IOpportunityAppService>();
            opportunityRepository = Resolve<IOpportunityRepository>();
        }

        [Fact]
        public void GetAllTest()
        {
            var query =  from m in opportunityRepository.GetAll()
                select m;

            var list = query.ToList();

            if(list.Count > 0)
            {
                var opp = list[0];
                var creator = opp.CreatorUserName;
                Console.WriteLine(creator);
            }

            Assert.True(list.Count > 0);
        }
    }
}
