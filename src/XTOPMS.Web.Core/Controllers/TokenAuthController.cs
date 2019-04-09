using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using Abp.UI;
using XTOPMS.Authentication.External;
using XTOPMS.Authentication.JwtBearer;
using XTOPMS.Authorization;
using XTOPMS.Authorization.Users;
using XTOPMS.Models.TokenAuth;
using XTOPMS.MultiTenancy;

namespace XTOPMS.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TokenAuthController : XTOPMSControllerBase
    {
        private readonly LogInManager _logInManager;
        private readonly ITenantCache _tenantCache;
        private readonly AbpLoginResultTypeHelper _abpLoginResultTypeHelper;
        private readonly TokenAuthConfiguration _configuration;
        private readonly IExternalAuthConfiguration _externalAuthConfiguration;
        private readonly IExternalAuthManager _externalAuthManager;
        private readonly UserRegistrationManager _userRegistrationManager;

        public TokenAuthController(
            LogInManager logInManager,
            ITenantCache tenantCache,
            AbpLoginResultTypeHelper abpLoginResultTypeHelper,
            TokenAuthConfiguration configuration,
            IExternalAuthConfiguration externalAuthConfiguration,
            IExternalAuthManager externalAuthManager,
            UserRegistrationManager userRegistrationManager)
        {
            _logInManager = logInManager;
            _tenantCache = tenantCache;
            _abpLoginResultTypeHelper = abpLoginResultTypeHelper;
            _configuration = configuration;
            _externalAuthConfiguration = externalAuthConfiguration;
            _externalAuthManager = externalAuthManager;
            _userRegistrationManager = userRegistrationManager;
        }

        [HttpPost]
        public async Task<AuthenticateResultModel> Authenticate([FromBody] AuthenticateModel model)
        {
            string tenancyName = string.Equals("XTOPMS", model.TenancyName, StringComparison.OrdinalIgnoreCase) ? null : model.TenancyName;
            // Add this for fix XTOPMS system api
            bool success = true;
            string[] authority = new string[] {"guest"};

            AuthenticateResultModel result = new AuthenticateResultModel
            {
                UserId = 0,
                Success = success,
                Authority = authority,
                AccessToken = "",
                EncryptedAccessToken = "",
                ExpireInSeconds = (int)_configuration.Expiration.TotalSeconds
            };

            try{
                var loginResult = await GetLoginResultAsync(
                    model.UserNameOrEmailAddress,
                    model.Password,
                    tenancyName // GetTenancyNameOrNull()
                );

                var accessToken = CreateAccessToken(CreateJwtClaims(loginResult.Identity));

                // TODO: write some code to get current user's roles.
                authority = authority.Append<String>("admin").ToArray(); // add a admin role.

                // Initiate result model
                result.UserId = loginResult.User.Id;
                result.AccessToken = accessToken;
                result.EncryptedAccessToken = GetEncrpyedAccessToken(accessToken);
                result.Success = success;
                result.Authority = authority;
                result.Code = ReturnCodeEnum.Success;

                return result;
            }
            catch(UserFriendlyException exc)
            {
                result.Success = false;
                result.Code = ReturnCodeEnum.ERROR_UNKNOW_REASON;
                result.Error = exc.Details;
            }
            catch (MySql.Data.MySqlClient.MySqlException mySqlException)
            {
                /*
                MySql.Data.MySqlClient.MySqlException(0x80004005): Unable to connect to any of the specified MySQL hosts.
                at MySqlConnector.Core.ServerSession.ConnectAsync(ConnectionSettings cs, ILoadBalancer loadBalancer, IOBehavior ioBehavior, CancellationToken cancellationToken) 
                in C:\projects\mysqlconnector\src\MySqlConnector\Core\ServerSession.cs:line 322
                at MySqlConnector.Core.ConnectionPool.GetSessionAsync(MySqlConnection connection, IOBehavior ioBehavior, CancellationToken cancellationToken) 
                in C:\projects\mysqlconnector\src\MySqlConnector\Core\ConnectionPool.cs:line 112
                at MySqlConnector.Core.ConnectionPool.GetSessionAsync(MySqlConnection connection, IOBehavior ioBehavior, CancellationToken cancellationToken) 
                in C:\projects\mysqlconnector\src\MySqlConnector\Core\ConnectionPool.cs:line 141
                at MySql.Data.MySqlClient.MySqlConnection.CreateSessionAsync(Nullable`1 ioBehavior, CancellationToken cancellationToken) 
                in C:\projects\mysqlconnector\src\MySqlConnector\MySql.Data.MySqlClient\MySqlConnection.cs:line 431
                at MySql.Data.MySqlClient.MySqlConnection.OpenAsync(Nullable`1 ioBehavior, CancellationToken cancellationToken) 
                in C:\projects\mysqlconnector\src\MySqlConnector\MySql.Data.MySqlClient\MySqlConnection.cs:line 175
                at MySql.Data.MySqlClient.MySqlConnection.Open() in C:\projects\mysqlconnector\src\MySqlConnector\MySql.Data.MySqlClient\MySqlConnection.cs:line 161
                at Microsoft.EntityFrameworkCore.Storage.RelationalConnection.OpenDbConnection(Boolean errorsExpected)
                at Microsoft.EntityFrameworkCore.Storage.RelationalConnection.Open(Boolean errorsExpected)
                at Microsoft.EntityFrameworkCore.Storage.RelationalConnection.BeginTransaction(IsolationLevel isolationLevel)
                at Pomelo.EntityFrameworkCore.MySql.Storage.Internal.MySqlExecutionStrategy.Execute[TState, TResult](TState state, Func`3 operation, Func`3 verifySucceeded)
                at Abp.EntityFrameworkCore.Uow.DbContextEfCoreTransactionStrategy.CreateDbContext[TDbContext](String connectionString, IDbContextResolver dbContextResolver)
                in D:\Github\aspnetboilerplate\src\Abp.EntityFrameworkCore\EntityFrameworkCore\Uow\DbContextEfCoreTransactionStrategy.cs:line 38
                at Abp.EntityFrameworkCore.Uow.EfCoreUnitOfWork.GetOrCreateDbContext[TDbContext](Nullable`1 multiTenancySide, String name)
                in D:\Github\aspnetboilerplate\src\Abp.EntityFrameworkCore\EntityFrameworkCore\Uow\EfCoreUnitOfWork.cs:line 120
                at Abp.EntityFrameworkCore.Repositories.EfCoreRepositoryBase`3.get_Table()
                in D:\Github\aspnetboilerplate\src\Abp.EntityFrameworkCore\EntityFrameworkCore\Repositories\EfCoreRepositoryBaseOfTEntityAndTPrimaryKey.cs:line 39
                at Abp.EntityFrameworkCore.Repositories.EfCoreRepositoryBase`3.GetAllIncluding(Expression`1[] propertySelectors)
                in D:\Github\aspnetboilerplate\src\Abp.EntityFrameworkCore\EntityFrameworkCore\Repositories\EfCoreRepositoryBaseOfTEntityAndTPrimaryKey.cs:line 88
                at Abp.EntityFrameworkCore.Repositories.EfCoreRepositoryBase`3.FirstOrDefaultAsync(Expression`1 predicate)
                in D:\Github\aspnetboilerplate\src\Abp.EntityFrameworkCore\EntityFrameworkCore\Repositories\EfCoreRepositoryBaseOfTEntityAndTPrimaryKey.cs:line 123
                at Abp.Threading.InternalAsyncHelper.AwaitTaskWithPostActionAndFinallyAndGetResult[T](Task`1 actualReturnValue, Func`1 postAction, Action`1 finalAction)
                at Abp.Authorization.AbpLogInManager`3.LoginAsyncInternal(String userNameOrEmailAddress, String plainPassword, String tenancyName, Boolean shouldLockout)
                at Abp.Authorization.AbpLogInManager`3.LoginAsync(String userNameOrEmailAddress, String plainPassword, String tenancyName, Boolean shouldLockout)
                at Abp.Threading.InternalAsyncHelper.AwaitTaskWithPostActionAndFinallyAndGetResult[T](Task`1 actualReturnValue, Func`1 postAction, Action`1 finalAction)
                at XTOPMS.Controllers.TokenAuthController.GetLoginResultAsync(String usernameOrEmailAddress, String password, String tenancyName)
                in / Work / Dotnet / XTOPMSCORE_master / src / XTOPMS.Web.Core / Controllers / TokenAuthController.cs:line 218
                at XTOPMS.Controllers.TokenAuthController.Authenticate(AuthenticateModel model)
                in / Work / Dotnet / XTOPMSCORE_master / src / XTOPMS.Web.Core / Controllers / TokenAuthController.cs:line 71
                */

                result.Success = false;
                result.Code = ReturnCodeEnum.ERROR_DATABASE_CANNOT_CONNECT;
                result.Error = mySqlException.Message;

            }
            catch (Exception exc)
            {
                result.Success = false;
                result.Code = ReturnCodeEnum.ERROR_UNKNOW_REASON;
                result.Error = exc.Message;
            }

            return result;
        }

        [HttpGet]
        public List<ExternalLoginProviderInfoModel> GetExternalAuthenticationProviders()
        {
            return ObjectMapper.Map<List<ExternalLoginProviderInfoModel>>(_externalAuthConfiguration.Providers);
        }

        [HttpPost]
        public async Task<ExternalAuthenticateResultModel> ExternalAuthenticate([FromBody] ExternalAuthenticateModel model)
        {
            var externalUser = await GetExternalUserInfo(model);

            var loginResult = await _logInManager.LoginAsync(new UserLoginInfo(model.AuthProvider, model.ProviderKey, model.AuthProvider), GetTenancyNameOrNull());

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    {
                        var accessToken = CreateAccessToken(CreateJwtClaims(loginResult.Identity));
                        return new ExternalAuthenticateResultModel
                        {
                            AccessToken = accessToken,
                            EncryptedAccessToken = GetEncrpyedAccessToken(accessToken),
                            ExpireInSeconds = (int)_configuration.Expiration.TotalSeconds
                        };
                    }
                case AbpLoginResultType.UnknownExternalLogin:
                    {
                        var newUser = await RegisterExternalUserAsync(externalUser);
                        if (!newUser.IsActive)
                        {
                            return new ExternalAuthenticateResultModel
                            {
                                WaitingForActivation = true
                            };
                        }

                        // Try to login again with newly registered user!
                        loginResult = await _logInManager.LoginAsync(new UserLoginInfo(model.AuthProvider, model.ProviderKey, model.AuthProvider), GetTenancyNameOrNull());
                        if (loginResult.Result != AbpLoginResultType.Success)
                        {
                            throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(
                                loginResult.Result,
                                model.ProviderKey,
                                GetTenancyNameOrNull()
                            );
                        }

                        return new ExternalAuthenticateResultModel
                        {
                            AccessToken = CreateAccessToken(CreateJwtClaims(loginResult.Identity)),
                            ExpireInSeconds = (int)_configuration.Expiration.TotalSeconds
                        };
                    }
                default:
                    {
                        throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(
                            loginResult.Result,
                            model.ProviderKey,
                            GetTenancyNameOrNull()
                        );
                    }
            }
        }

        private async Task<User> RegisterExternalUserAsync(ExternalAuthUserInfo externalUser)
        {
            var user = await _userRegistrationManager.RegisterAsync(
                externalUser.Name,
                externalUser.Surname,
                externalUser.EmailAddress,
                externalUser.EmailAddress,
                Authorization.Users.User.CreateRandomPassword(),
                true
            );

            user.Logins = new List<UserLogin>
            {
                new UserLogin
                {
                    LoginProvider = externalUser.Provider,
                    ProviderKey = externalUser.ProviderKey,
                    TenantId = user.TenantId
                }
            };

            await CurrentUnitOfWork.SaveChangesAsync();

            return user;
        }

        private async Task<ExternalAuthUserInfo> GetExternalUserInfo(ExternalAuthenticateModel model)
        {
            var userInfo = await _externalAuthManager.GetUserInfo(model.AuthProvider, model.ProviderAccessCode);
            if (userInfo.ProviderKey != model.ProviderKey)
            {
                throw new UserFriendlyException(L("CouldNotValidateExternalUser"));
            }

            return userInfo;
        }

        private string GetTenancyNameOrNull()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return _tenantCache.GetOrNull(AbpSession.TenantId.Value)?.TenancyName;
        }

        private async Task<AbpLoginResult<Tenant, User>> GetLoginResultAsync(string usernameOrEmailAddress, string password, string tenancyName)
        {
            var loginResult = await _logInManager.LoginAsync(usernameOrEmailAddress, password, tenancyName);

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    return loginResult;
                default:
                    throw _abpLoginResultTypeHelper.CreateExceptionForFailedLoginAttempt(loginResult.Result, usernameOrEmailAddress, tenancyName);
            }
        }

        private string CreateAccessToken(IEnumerable<Claim> claims, TimeSpan? expiration = null)
        {
            var now = DateTime.UtcNow;

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration.Issuer,
                audience: _configuration.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(expiration ?? _configuration.Expiration),
                signingCredentials: _configuration.SigningCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }

        private static List<Claim> CreateJwtClaims(ClaimsIdentity identity)
        {
            var claims = identity.Claims.ToList();
            var nameIdClaim = claims.First(c => c.Type == ClaimTypes.NameIdentifier);

            // Specifically add the jti (random nonce), iat (issued timestamp), and sub (subject/user) claims.
            claims.AddRange(new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, nameIdClaim.Value),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64)
            });

            return claims;
        }

        private string GetEncrpyedAccessToken(string accessToken)
        {
            return SimpleStringCipher.Instance.Encrypt(accessToken, AppConsts.DefaultPassPhrase);
        }
    }
}
