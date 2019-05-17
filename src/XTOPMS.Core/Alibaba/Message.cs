//
//  Message.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General License for more details.
//
//  You should have received a copy of the GNU Lesser General License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace XTOPMS.Alibaba
{
    public interface IMessage
        : IXTOPMSEntity<long>
    {
        long RefId { get; set; }
        long MsgId { get; set; }
        long GmtBorn { get; set; }
        int RetryCount { get; set; }
        string Data { get; set; }
        [StringLength(50)]
        string UserInfo { get; set; }
        [StringLength(50)]
        string Type { get; set; }

        // string ExtraInfo { get; set; }
    }

    [Table("AlibabaMessage")]
    public class Message
        : XTOPMSEntity<long>
        , IMessage
        , IExtendableObject
    {
        Message(): base()
        {
        }

        public long RefId { get; set; }
        public long MsgId { get; set; }
        public long GmtBorn {get; set;}
        public int RetryCount { get; set; }
        public string Data {get; set;}
        public string UserInfo {get; set;}
        public string Type {get; set;}

        // public string ExtraInfo {get; set;}
    }
}
