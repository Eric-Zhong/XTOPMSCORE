using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace XTOPMS.Models.TokenAuth
{
    public class AuthenticateModel
    {
        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        public string Password { get; set; }

        // XTOPMS: Add tender name query variable for set tenant's name
        public string TenancyName { get; set; }

        public bool RememberClient { get; set; }
    }
}
