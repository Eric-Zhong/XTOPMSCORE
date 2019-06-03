//
//  AlibabaCallbackMessageAppService.cs
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
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Auditing;
using Abp.Authorization;
using Abp.BackgroundJobs;
using Abp.Domain.Repositories;
using XTOPMS.Alibaba.Dto;
using XTOPMS.Application.Dto;
using XTOPMS.Authorization;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{
    public interface IAlibabaCallbackMessageAppService
        : IAsyncCrudAppService<CallbackMessageDto, long, QueryBaseDto>
    {
        Task<PagedResultDto<CallbackMessageDto>> Query(QueryBaseDto input);
        void Resend(List<long> ids);
    }

    [Audited]
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class AlibabaCallbackMessageAppService
        : AsyncCrudAppService<CallbackMessage, CallbackMessageDto, long, QueryBaseDto>
        , IAlibabaCallbackMessageAppService
    {
        readonly IBackgroundJobManager backgroundJobManager;

        public AlibabaCallbackMessageAppService(
            IRepository<CallbackMessage, long> repository,
            IBackgroundJobManager _backgroundJobManager
            ) 
            : base(repository)
        {
            backgroundJobManager = _backgroundJobManager;
        }

        public async Task<PagedResultDto<CallbackMessageDto>> Query(QueryBaseDto input)
        {
            return await this.GetAll(input);
        }

        public virtual void Resend(List<long> ids)
        {
            foreach(var id in ids)
            {
                var callbackMessage = Repository.Get(id);
                var message = callbackMessage.Body;

                var input = new CallbackDto()
                {
                    Message = message,
                    Signature = id.ToString()
                };

                backgroundJobManager.Enqueue<AlibabaCallbackJob, CallbackDto>(input);

                callbackMessage.Status = CallbackMessageStatus.Resend;
            }
        }
    }
}
