using com.alibaba.openapi.client.entity;
using com.alibaba.openapi.client.http;
using com.alibaba.openapi.client.policy;
using com.alibaba.trade.param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace com.alibaba.openapi.client
{
    public class SyncAPIClient
    {
        private ClientPolicy clientPolicy;

        public SyncAPIClient(String appKey, String appSecret)
        {
            this.clientPolicy = new ClientPolicy();
            this.clientPolicy.AppKey = appKey;
            this.clientPolicy.SecretKey = appSecret;
        }

        public SyncAPIClient(String appKey, String appSecret, String gatewayHost)
        {
            this.clientPolicy = new ClientPolicy();
            this.clientPolicy.AppKey = appKey;
            this.clientPolicy.SecretKey = appSecret;
            this.clientPolicy.ServerHost = gatewayHost;
        }

        public SyncAPIClient(ClientPolicy clientPolicy)
        {
            this.clientPolicy = clientPolicy;
        }

        public T send<T>(Request request, RequestPolicy policy)
        {
            HttpClient httpClient = new HttpClient(clientPolicy);
            T result = httpClient.request<T>(request, policy);
            return result;
        }

        public Res execute<Res>(GatewayAPIRequest gatewayAPIRequest, String accessToken)
        {
            HttpClient httpClient = new HttpClient(clientPolicy);
            RequestPolicy policy = new RequestPolicy();
            policy.UseHttps = true;
            Request request = new Request();
            request.ApiId = gatewayAPIRequest.ApiId;
            request.RequestEntity = gatewayAPIRequest;
            request.AccessToken = accessToken;
            Res result = httpClient.request<Res>(request, policy);
            return result;
        }


        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="code">Code.</param>
        public AuthorizationToken getToken(String code)
        {
            // https://gw.open.1688.com/openapi/http/1/system.oauth2/getToken/YOUR_APPKEY
            /*
                ?grant_type = authorization_code
                &need_refresh_token=true
                &client_id= YOUR_APPKEY
                &client_secret= YOUR_APPSECRET
                &redirect_uri=YOUR_REDIRECT_URI
                &code=CODE
            */
            APIId apiId = new APIId();
            apiId.Name = "getToken";
            apiId.NamespaceValue = "system.oauth2";
            apiId.Version = 1;

            Request request = new Request();
            request.ApiId = apiId;

            request.AddtionalParams["code"] = code;
            request.AddtionalParams["grant_type"] = "authorization_code";
            request.AddtionalParams["need_refresh_token"] = true;
            request.AddtionalParams["client_id"] = clientPolicy.AppKey;
            request.AddtionalParams["client_secret"] = clientPolicy.SecretKey;
            request.AddtionalParams["redirect_uri"] = "default";

            RequestPolicy oauthPolicy = new RequestPolicy();
            oauthPolicy.HttpMethod = "POST";
            oauthPolicy.UseHttps = true;
            oauthPolicy.RequestSendTimestamp = false;
            oauthPolicy.RequestProtocol = Protocol.http;
            oauthPolicy.ResponseProtocol = Protocol.json2;

            return this.send<AuthorizationToken>(request, oauthPolicy);
        }


        /// <summary>
        /// Refreshs the token.
        /// </summary>
        /// <returns>The token.</returns>
        /// <param name="refreshToken">Refresh token.</param>
        public AuthorizationToken refreshToken(String refreshToken)
        {
            // https://gw.open.1688.com/openapi/param2/1/system.oauth2/getToken/YOUR_APPKEY
            APIId apiId = new APIId();
            apiId.Name = "getToken";
            apiId.NamespaceValue = "system.oauth2";
            apiId.Version = 1;

            Request request = new Request();
            request.ApiId = apiId;

            request.AddtionalParams["refreshToken"] = refreshToken;
            request.AddtionalParams["grant_type"] = "refresh_token";
            request.AddtionalParams["client_id"] = clientPolicy.AppKey;
            request.AddtionalParams["client_secret"] = clientPolicy.SecretKey;
            request.AddtionalParams["redirect_uri"] = "default";

            RequestPolicy oauthPolicy = new RequestPolicy();
            oauthPolicy.UseHttps = true;

            return this.send<AuthorizationToken>(request, oauthPolicy);
        }


        /// <summary>
        /// Refreshs the refresh token.
        /// </summary>
        /// <returns>The refresh token.</returns>
        /// <param name="refreshToken">Refresh token.</param>
        public AuthorizationToken refreshRefreshToken(string accessToken, string refreshToken)
        {
            // https://gw.open.1688.com/openapi/param2/1/system.oauth2/postponeToken/YOUR_APPKEY
            APIId apiId = new APIId();
            apiId.Name = "postponeToken";
            apiId.NamespaceValue = "system.oauth2";
            apiId.Version = 1;

            Request request = new Request();

            request.ApiId = apiId;
            request.AddtionalParams["client_id"] = clientPolicy.AppKey;
            request.AddtionalParams["client_secret"] = clientPolicy.SecretKey;
            request.AddtionalParams["refresh_token"] = refreshToken;
            request.AddtionalParams["access_token"] = accessToken;

            RequestPolicy oauthPolicy = new RequestPolicy();
            oauthPolicy.UseHttps = true;

            return this.send<AuthorizationToken>(request, oauthPolicy);
        }

    }
}

