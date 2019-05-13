//
//  NoticeManage.cs
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
using Abp.Domain.Services;

namespace XTOPMS.Notification
{

    public interface INoticeManage : IDomainService
    {
        string GetStateText(int state);
    }

    public class NoticeManage 
        : DomainService
        , INoticeManage
    {
        public NoticeManage(): base()
        {
        }

        public string GetStateText(int state)
        {
            string statueName = "Unkown";
            switch (state)
            {
                case 0:
                    statueName = "Unread";
                    break;
                case 1:
                    statueName = "Readed";
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
            return statueName;
        }
    }
}
