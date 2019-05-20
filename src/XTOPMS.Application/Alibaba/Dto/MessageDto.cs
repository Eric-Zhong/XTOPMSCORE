//
//  CallbackMessageDto.cs
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
using Abp.AutoMapper;
using XTOPMS.Application.Dto;
using XTOPMS.Dto;

namespace XTOPMS.Alibaba.Dto
{
    [Serializable]
    [AutoMap(typeof(Message))]
    public class MessageDto: XTOPMSEntityDto
    {
        public long MsgId { get; set; }
        public long GmtBorn { get; set; }
        /// <summary>
        /// Map to ExtensionData Field at Entity.
        /// Map config at MessageMapProfile.cs
        /// </summary>
        /// <value>The data.</value>
        public DataDto Data { get; set; }
        public string BusinessData { get; set; }
        public string UserInfo { get; set; }
        public string Type { get; set; }
        public string BizKey { get; set; }
        public string ExtraInfo { get; set; }
        public int RetryCount { get; set; }

        public MessageDto()
        {
        }
    }


    public class MessageFilterFields
    {
        List<string> Type { get; set; }
        List<int> Status { get; set; }
    }


    public class MessagePagedSortedFilterDto: PagedSortedFilterRequestBaseDto<MessageFilterFields>
    {

    }
}
