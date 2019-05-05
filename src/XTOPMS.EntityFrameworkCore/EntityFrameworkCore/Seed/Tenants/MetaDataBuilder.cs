//
//  MetaDataBuilder.cs
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
using System.Collections.Generic;
using XTOPMS.Metadata;

namespace XTOPMS.EntityFrameworkCore.Seed.Tenants
{
    public class MetaDataBuilder
    {
        private readonly XTOPMSDbContext _context;
        private readonly int _tenantId;

        public MetaDataBuilder(XTOPMSDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            Console.WriteLine("Begin initialize metadata. ");
            Init_CustomerCategory();
            Console.WriteLine("Finish initialize metadata. ");
        }


        private void Init_CustomerCategory()
        {
            Console.WriteLine("<Customer Category>");

            List<CustomerCategory> list = new List<CustomerCategory>();

            // Init data
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010001, Code = "100010001", Name = "业主" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010002, Code = "100010002", Name = "总包方" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010003, Code = "100010003", Name = "分包方" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010004, Code = "100010004", Name = "施工方" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010005, Code = "100010005", Name = "供货方" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010006, Code = "100010006", Name = "监理方" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010007, Code = "100010007", Name = "研究院" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010008, Code = "100010008", Name = "代理" });
            list.Add(new CustomerCategory { TenantId = _tenantId, CreatorUserId = 2, IsActive = true, Id = 100010009, Code = "100010009", Name = "竞争对手" });

            foreach (var item in list)
            {
                Console.Write(string.Format("{0}\t{1}\t", item.Id, item.Name));
                var find = _context.CustomerCategory.Find(item.Id);
                if (find == null)
                {
                    _context.CustomerCategory.Add(item);
                    Console.WriteLine("Added");
                }
                else
                {
                    Console.WriteLine("Ignored");
                }
            }

            _context.SaveChanges();
        }
    }
}
