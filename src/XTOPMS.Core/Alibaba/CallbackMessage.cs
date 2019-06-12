//
//  AlibabaCallbackMessage.cs
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
using Abp.Domain.Entities.Auditing;

namespace XTOPMS.Alibaba
{

    public interface ICallbackMessage
        : IEntity<long>
        , IHasCreationTime
    {
        string Body { get; set; }
        CallbackMessageStatus Status { get; set; }
    }

    public enum CallbackMessageStatus: int
    {
        New = 0,
        Inprocess = 1,
        Success = 2,
        Failed = 3,
        Canceled = 4,
        Ignored = 5,
        NotFoundMember = 6,
        ParseError = 7,
        InterfaceThrowError = 8,
        Resend = 9,
        Reduplicative = 10
    }

    /// <summary>
    /// Recive alibaba callback message.
    /// </summary>
    [Table("AlibabaCallbackMessage")]
    public class CallbackMessage
        : Entity<long>
        , ICallbackMessage
    {
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }
        public CallbackMessageStatus Status { get; set; }

        public CallbackMessage()
        {
        }
    }
}
