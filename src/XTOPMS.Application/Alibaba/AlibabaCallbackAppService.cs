//
//  AlibabaCallbackAppService.cs
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
using Abp.Application.Services;
using Abp.BackgroundJobs;
using Microsoft.AspNetCore.Http;
using XTOPMS.Alibaba.Dto;

namespace XTOPMS.Alibaba
{

    public interface IAlibabaCallbackAppService: IApplicationService
    {
        void Do();
    }

    public class AlibabaCallbackAppService
        : XTOPMSAppServiceBase
        , IAlibabaCallbackAppService
    {
        readonly IHttpContextAccessor httpContext;
        readonly IBackgroundJobManager backgroundJobManager;

        public AlibabaCallbackAppService(
            IHttpContextAccessor _httpContext,
            IBackgroundJobManager _backgroundJobManager)
        {
            httpContext = _httpContext;
            backgroundJobManager = _backgroundJobManager;
        }

        public void Do()
        {
            HttpContext hcx = this.httpContext.HttpContext;
            var message = hcx.Request.Form["message"];
            var _aop_signature = hcx.Request.Form["_aop_signature"];

            var input = new CallbackDto()
            {
                Message = message,
                Signature = _aop_signature
            };

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + " Alibaba Callback: ");
            Console.WriteLine("\tSignature: " + input.Signature);
            Console.WriteLine("\tMessage: " + input.Message);

            // Wirte a log
            this.Logger.Info(message);

            // Create background job for save the callback/message.
            backgroundJobManager.Enqueue<AlibabaCallbackJob, CallbackDto>(input);

        }
    }
}
