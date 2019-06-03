//
//  AccessTokenManager.cs
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
using System.Globalization;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using com.alibaba.openapi.client;
using com.alibaba.openapi.client.exception;
using Newtonsoft.Json;
using XTOPMS.Email;
using XTOPMS.EntityFrameworkCore.Repositories;

namespace XTOPMS.Alibaba
{
    public interface IAccessTokenManager: IDomainService
    {
        void UpdateToken();
        void UpdateRefreshToken();
        void RefreshAccessToken(AccessToken token);
        void InitializeToken(AccessToken token, string code);
        void RefreshRefreshToken(AccessToken token);
        AccessToken GetByMemberId(string memberId);
    }

    public class AccessTokenManager
        : DomainService
        , IAccessTokenManager
    {

        readonly IAccessTokenRepository accessTokenRepository;
        readonly IEmailManager emailManager;
        readonly IUnitOfWorkManager unitOfWorkManager;

        public AccessTokenManager(
            IAccessTokenRepository _accessTokenRepository,
            IEmailManager _emailManager,
            IUnitOfWorkManager _unitOfWorkManager)
        {
            accessTokenRepository = _accessTokenRepository;
            emailManager = _emailManager;
            unitOfWorkManager = _unitOfWorkManager;
        }


        /// <summary>
        /// 使用 code 去刷新新的 Access Token & Refresh Token 信息
        /// </summary>
        /// <param name="token">Token.</param>
        /// <param name="code">Code.</param>
        public virtual void InitializeToken(AccessToken token, string code)
        {
            /*
            {
                "access_token": "3f611def-9f31-4f21-a95c-0ca1b0922309",
                "aliId": "3305067292",
                "refresh_token": "14f0af01-0664-4fa0-a34f-5c0f815247f9",
                "resource_owner": "ericzhongxu",
                "expires_in": "35999",
                "refresh_token_timeout": "20191014003220000+0800",
                "memberId": "b2b-3305067292666fa"
            }
            */
            SyncAPIClient client = new SyncAPIClient(token.App_Key, token.App_Secret);

            var newToken = client.getToken(code);
            newToken.setExpires_in(newToken.getExpires_in());

            token.Access_Token = newToken.getAccess_token();
            token.AliId = newToken.getAliId().ToString();
            token.Refresh_Token = newToken.getRefresh_token();
            token.Resource_Owner = newToken.getResource_owner();
            token.Expires_In = newToken.getExpires_time();
            token.Refresh_Token_Timeout = TransformDateTime(newToken.getRefresh_token_timeout());
            token.MemberId = newToken.getMemberId();

            accessTokenRepository.Update(token);

            Console.WriteLine(string.Format(
                "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",
                token.Id,
                token.App_Key,
                token.App_Secret,
                code,
                token.Access_Token,
                token.AliId,
                token.Resource_Owner,
                token.MemberId,
                token.Expires_In.ToString("yyyy-MM-dd HH:mm:ss")));
        }


        /// <summary>
        /// Refreshs the refresh token.
        /// </summary>
        /// <param name="token">Token.</param>
        public virtual void RefreshRefreshToken(AccessToken token)
        {
            /*
            {
                "error_description": "refreshToken is too long to expire with expireTime 20191014003220000+0800",
                "error": "invalid_request"
            }
            */
            try
            {
                SyncAPIClient client = new SyncAPIClient(token.App_Key, token.App_Secret);
                var newToken = client.refreshRefreshToken(token.Access_Token, token.Refresh_Token);
                token.Access_Token = newToken.getAccess_token();
                token.Expires_In = newToken.getExpires_time();
                token.Refresh_Token = newToken.getRefresh_token();
                token.Refresh_Token_Timeout = TransformDateTime(newToken.getRefresh_token_timeout());
                token.AliId = newToken.getAliId().ToString();
                token.Resource_Owner = newToken.getResource_owner();
                token.MemberId = newToken.getMemberId();
                token.Status = (int)CallbackMessageStatus.Success;
                token.Comment = "Success. " + JsonConvert.SerializeObject(newToken);
            }
            catch (Exception err)
            {
                token.Status = (int)CallbackMessageStatus.Failed;
                token.Comment = err.ToString();

                // Notice to admin
                // Error code : 200
                string body = "";
                try
                {
                    OceanException oceanException = err as OceanException;
                    body = @"
Hi admin,

There are some error when executte refresh 'Refresh-Token' background job.
";
                body += @"
Error Code: " + oceanException.getError_code();
                body += @"
Error Message: " + oceanException.getError_message();
                body += @"
Detail: " + oceanException.ToString();
                }
                finally {
                    body += "\r\nError: " + err.ToString();
                }

//                string body = @"
//Hi admin,

//There are some error when executte refresh 'Refresh-Token' background job.
//";
//                body += @"
//Error Code: " + err.getError_code();
//                body += @"
//Error Message: " + err.getError_message();
//                body += @"
//Detail: " + err.ToString();

                emailManager.SendMail("[XTOPMS] 刷新 RefreshToken 时出现异常 (Error 200)", body, false);
            }
            accessTokenRepository.Update(token);
        }


        /// <summary>
        /// 使用 refresh token 来重新刷一个新的 access Token
        /// </summary>
        /// <param name="token">Token.</param>
        public virtual void RefreshAccessToken(AccessToken token)
        {
            /*
            {
                "access_token": "76dee230-a91b-4178-aa25-83855bb7808b",
                "aliId": "3305067292",
                "resource_owner": "ericzhongxu",
                "expires_in": "35999",
                "memberId": "b2b-3305067292666fa"
            }
            */
            try
            {
                SyncAPIClient client = new SyncAPIClient(token.App_Key, token.App_Secret);
                var oldAccessToken = token.Access_Token;

                var newToken = client.refreshToken(token.Refresh_Token);

                token.Access_Token = newToken.getAccess_token();
                token.AliId = newToken.getAliId().ToString();
                token.Resource_Owner = newToken.getResource_owner();
                token.Expires_In = DateTime.Now.AddSeconds(double.Parse(newToken.getExpires_in().ToString()));
                // token.Expires_In = newToken.getExpires_time();
                token.MemberId = newToken.getMemberId();
                token.Status = (int)CallbackMessageStatus.Success;
                token.Comment = "Success. " + JsonConvert.SerializeObject(newToken);

                Console.WriteLine(string.Format(
                    "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}",
                    token.Id,
                    token.App_Key,
                    token.App_Secret,
                    oldAccessToken,
                    token.Access_Token,
                    token.AliId,
                    token.Resource_Owner,
                    token.MemberId,
                    token.Expires_In.ToString("yyyy-MM-dd HH:mm:ss")));

            }
            catch (Exception err)
            {
                token.Status = (int)CallbackMessageStatus.Failed;
                token.Comment = err.ToString();

                // Notice to admin
                // Error code : 210
                string tokenJson = JsonConvert.SerializeObject(token);
                emailManager.SendMail("[XTOPMS] 刷新 AccessToken 时出现异常 (Error 210)", tokenJson + "\r\n\r\n" + err.ToString(), false);
            }

            accessTokenRepository.Update(token);
        }


        public virtual void UpdateToken()
        {
            var list = accessTokenRepository.GetAllAccessTokenWillTimeout().Result;         // Timeout after 2 hours.
            var count = list.Count;
            Console.WriteLine("There are " + count.ToString() + " tokens need to refresh.");
            foreach (var token in list)
            {
                this.RefreshAccessToken(token);
            }
        }


        public virtual void UpdateRefreshToken()
        {
            var list = accessTokenRepository.GetAllRefreshTokenWillTimeout().Result;        // Timeout after 5 days.
            foreach (var item in list)
            {
                this.RefreshRefreshToken(item);
            }
        }


        private DateTime TransformDateTime(string value)
        {
            // "refresh_token_timeout": "20191014003220000+0800"
            DateTime output = DateTime.ParseExact(
                value,
                "yyyyMMddHHmmssfffzzz",
                CultureInfo.InvariantCulture
                );
            return output;
        }


        public virtual AccessToken GetByMemberId(string memberId)
        {
            this.UnitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant, AbpDataFilters.MustHaveTenant);
            var result = accessTokenRepository.FirstOrDefault(t => t.MemberId == memberId);
            return result;
        }

    }
}
