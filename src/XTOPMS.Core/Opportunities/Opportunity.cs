//
//  Opportunity.cs
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
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using XTOPMS.Authorization.Users;
using XTOPMS.Customers;
using XTOPMS.Metadata;

namespace XTOPMS.Opportunities
{

    public interface IOpportunityEntity
        : IOpportunityEntity<long, User, Customer, BusinessCategory>
    {

    }


    /// <summary>
    /// Opportunity basic properties.
    /// </summary>
    public interface IOpportunityEntity<TPrimaryKey, TUser, TCustomer, TBusinessCategory>
        : IXTOPMSEntity<TPrimaryKey, TUser>
        where TUser: class , IEntity<long>
        where TCustomer: class, IEntity<long>
    {
        long? OwnerId { get; set; }
        long? GeneralContractorId { get; set; }
        long? AgencyId { get; set; }
        long? SalesId { get; set; }
        string BusinessCategoryId { get; set; }
        decimal Amount { get; set; }
        string Currency { get; set; }
        string Region { get; set; }
        string Country { get; set; }
        string Province { get; set; }
        string City { get; set; }
        string ScheduleData { get; set; }
        string GeographicData { get; set; }

        // Foreign
        TUser Sales { get; set; }
        TCustomer Owner { get; set; }
        TCustomer GeneralContractor { get; set; }
        TCustomer Agency { get; set; }
        TBusinessCategory BusinessCategory { get; set; }
    }

    [Table("XTOPMS_Opportunity")]
    public class Opportunity : 
        XTOPMSEntity, 
        IXTOPMSEntity, 
        IOpportunityEntity
    {
        /// <summary>
        /// 业主
        /// </summary>
        /// <value>The owner.</value>
        public long? OwnerId { get; set; }
        /// <summary>
        /// 总包方
        /// </summary>
        /// <value>The general contractor identifier.</value>
        public long? GeneralContractorId { get; set; }
        /// <summary>
        /// 代理
        /// </summary>
        /// <value>The general agency identifier.</value>
        public long? AgencyId { get; set; }
        /// <summary>
        /// 对项目负责的本方销售代表
        /// </summary>
        /// <value>The sales identifier.</value>
        public long? SalesId { get; set; }
        [ForeignKey("SalesId")]
        public User Sales { get; set; }
        public decimal Amount { get; set; }
        [StringLength(50)]
        public string Currency { get; set; }
        [StringLength(50)]
        public string Region { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(50)]
        public string Province { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        /// <summary>
        /// 进度数据，计划用在前端界面显示时所显示的进度信息。
        /// </summary>
        /// <value>JSON String</value>
        [StringLength(4000)]
        public string ScheduleData { get; set; }
        /// <summary>
        /// 地理坐标位置信息
        /// </summary>
        /// <value>The geographic data.</value>
        [StringLength(4000)]
        public string GeographicData { get; set; }

        [ForeignKey("OwnerId")]
        public Customer Owner { get; set; }
        [ForeignKey("GeneralContractorId")]
        public Customer GeneralContractor { get; set; }
        [ForeignKey("AgencyId")]
        public Customer Agency { get; set; }
        public string BusinessCategoryId { get; set; }
        [ForeignKey("BusinessCategoryId")]
        public BusinessCategory BusinessCategory { get; set; }

        public Opportunity()
        {
            Amount = 0;
        }
    }
}