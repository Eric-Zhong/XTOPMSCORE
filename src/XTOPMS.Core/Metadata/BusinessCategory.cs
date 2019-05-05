//
//  BusinessCategory.cs
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
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace XTOPMS.Metadata
{
    public interface IBusinessCategory: IEntity<string>, IMustHaveTenant, IPassivable
    {
        string ParentId { get; set; }
        string Name { get; set; }
        string FullKey { get; set; }
        string FullPath { get; set; }
        string Comment { get; set; }
        int Level { get; set; }
        bool IsLeaf { get; set; }

    }

    [Table("XTOPMS_BusinessCategory")]
    public class BusinessCategory : Entity<string>, IBusinessCategory
    {
        public string ParentId {get;set;}
        public string Name {get;set;}
        public string FullKey {get;set;}
        public string FullPath {get;set;}
        public string Comment {get;set;}
        public int Level {get;set;}
        public bool IsLeaf {get;set;}
        public int TenantId {get;set;}
        public bool IsActive {get;set;}

        [ForeignKey("ParentId")]
        public BusinessCategory Parent { get; set; }
    }
}
