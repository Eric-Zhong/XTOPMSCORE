//
//  ErrorCodeEnum.cs
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
namespace XTOPMS
{
    /// <summary>
    /// 整个系统在函数返回数值参数时，统一在这里进行了定义。
    /// 格式定义 nnhhhh
    /// nn: 模块编号, 00: 系统核心内部定义
    /// </summary>
    public enum ReturnCodeEnum: int
    {
        /* 00 : System */
        Success = 0,

        /* 005___ : 系统级报错信息 */
        ERROR_UNKNOW_REASON = 5000,
        ERROR_DATABASE_CANNOT_CONNECT = 5001,
    }
}
