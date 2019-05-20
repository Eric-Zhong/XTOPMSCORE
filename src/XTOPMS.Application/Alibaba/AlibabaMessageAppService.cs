//
//  AlibabaMessageAppService.cs
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
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using XTOPMS;
using XTOPMS.Alibaba.Dto;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{
    public interface IAlibabaMessageAppService
        : IXTOPMSAsyncCrudAppService<
            MessageDto
            , long
            , MessagePagedSortedFilterDto
            , MessageDto
            , MessageDto
            , MessageDto
            , MessageDto>
    {
        void Retry(List<MessageDto> entities);
    }

    public class AlibabaMessageAppService
        : XTOPMSAsyncCrudAppService<
            Message
            , MessageDto
            , long
            , MessagePagedSortedFilterDto
            , MessageDto
            , MessageDto
            , MessageDto
            , MessageDto>
        , IAlibabaMessageAppService
    {
        public AlibabaMessageAppService(IAlibabaMessageRepository repository) : base(repository)
        {
        }

        public override Task<MessageDto> Get(MessageDto input)
        {
            return base.Get(input);
        }

        /// <summary>
        /// 管理员设置要求重试
        /// </summary>
        /// <param name="entities">Entities.</param>
        public void Retry(List<MessageDto> entities)
        {
            foreach(var item in entities)
            {
                var entity = this.Repository.Get(item.Id);
                entity.Status = (int)CallbackMessageStatus.New;
                entity.Comment = "设置成 Retry";
                entity.RetryCount = 0;
                this.Repository.Update(entity);
            }
        }
    }
}
