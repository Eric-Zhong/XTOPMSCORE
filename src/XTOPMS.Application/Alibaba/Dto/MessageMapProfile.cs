//
//  MessageMapProfile.cs
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
using AutoMapper;
using Newtonsoft.Json;

namespace XTOPMS.Alibaba.Dto
{
    public class MessageMapProfile: Profile
    {
        public MessageMapProfile()
        {
            /*
            CreateMap<MessageDto, Message>().ForMember(entity => entity.Data, map => map.MapFrom(dto => JsonConvert.SerializeObject(dto.Data)));
            CreateMap<Message, MessageDto>().ForMember(dto => dto.Data, map => map.MapFrom(entity => JsonConvert.DeserializeObject<Dictionary<string, string>>(entity.Data)));
            */           
        }
    }
}
