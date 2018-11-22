using Abp.Authorization.Users;

namespace XTOPMS.Models.TokenAuth
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }

        public string EncryptedAccessToken { get; set; }

        public int ExpireInSeconds { get; set; }

        public long UserId { get; set; }

        /// <summary>
        /// Gets or sets the authority.
        /// </summary>
        /// <value>The authority.</value>
        public string[] Authority
        {
            get;
            set;
        }

        public bool Success
        {
            get;
            set;
        }

        public string Error
        {
            get;
            set;
        }
    }
}
