//
//  AccessToken.cs
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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XTOPMS.Alibaba
{

    public interface IAccessToken
    {
        string Access_Token { get; }
        string App_Key { get; set; }
        string App_Secret { get; set; }
    }

    [Table("Alibaba_AccessToken")]
    public class AccessToken: XTOPMSEntity, IAccessToken
    {

        [StringLength(50)]
        public string App_Key { get; set; }
        [StringLength(50)]
        public string App_Secret { get; set; }
        [StringLength(50)]
        public string AliId { get; set; }
        [StringLength(50)]
        public string Resource_Owner { get; set; }
        [StringLength(50)]
        public string MemberId { get; set; }
        [StringLength(50)]
        public string Access_Token { get; set; }
        /// <summary>
        /// Token's timeout date and time.
        /// </summary>
        /// <value>The expires in.</value>
        public DateTime Expires_In { get; set; }
        [StringLength(50)]
        public string Refresh_Token { get; set; }
        public DateTime Refresh_Token_Timeout { get; set; }

        public AccessToken()
        {
        }
    }
}
