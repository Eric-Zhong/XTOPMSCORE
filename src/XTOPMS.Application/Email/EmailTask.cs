//
//  EmailDto.cs
//
//  Author:
//       Eric-Zhong Xu <zhong.xu@biztalkgroup.com>
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
using XTOPMS.Documents.Dto;
using XTOPMS.Users.Dto;

namespace XTOPMS.Email
{
    public interface IEmailTask
    {
        DateTime CreationTime { get; set; }
        string Subject { get; set; }
        string Body { get; set; }
        bool IsBodyHtml { get; set; }
        UserDto From { get; set; }
        List<UserDto> To { get; set; }
        List<UserDto> Cc { get; set; }
        List<DocumentDto> Attachments { get; set; }
    }

    public class EmailTask
        : IEmailTask
    {
        public DateTime CreationTime { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public UserDto From { get; set; }
        public List<UserDto> To { get; set; }
        public List<UserDto> Cc { get; set; }
        public List<DocumentDto> Attachments { get; set; }
        public bool IsBodyHtml { get; set; }

        public EmailTask()
        {
            CreationTime = DateTime.Now;
            IsBodyHtml = false;
            From = new UserDto();
            To = new List<UserDto>();
        }
    }
}
