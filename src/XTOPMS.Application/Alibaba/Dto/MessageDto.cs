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
namespace XTOPMS.Alibaba.Dto
{
    public class MessageDto
    {

        public long MsgId { get; set; }
        public long GmtBorn { get; set; }
        public string Data { get; set; }
        public string UserInfo { get; set; }
        public string Type { get; set; }
        public string ExtraInfo { get; set; }

        public MessageDto()
        {
        }
    }
}
