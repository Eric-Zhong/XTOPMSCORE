using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Configuration;
using Abp.Localization;
using Abp.Net.Mail;

namespace XTOPMS.EntityFrameworkCore.Seed.Host
{
    public class DefaultSettingsCreator
    {
        private readonly XTOPMSDbContext _context;

        public DefaultSettingsCreator(XTOPMSDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            // Emailing
            AddSettingIfNotExists(EmailSettingNames.DefaultFromAddress, "zhong.xu@biztalkgroup.com");
            AddSettingIfNotExists(EmailSettingNames.DefaultFromDisplayName, "Supporter(XTOPMS)");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Domain, "");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Host, "smtp.exmail.qq.com");
            AddSettingIfNotExists(EmailSettingNames.Smtp.UserName, "zhong.xu@biztalkgroup.com");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Password, "w3vjyCuxmA4i4GS8");
            //AddSettingIfNotExists(EmailSettingNames.Smtp.Port, "465");
            //AddSettingIfNotExists(EmailSettingNames.Smtp.EnableSsl, "true");
            AddSettingIfNotExists(EmailSettingNames.Smtp.Port, "25");
            AddSettingIfNotExists(EmailSettingNames.Smtp.EnableSsl, "true");
            AddSettingIfNotExists(EmailSettingNames.Smtp.UseDefaultCredentials, "false");

            // Languages
            AddSettingIfNotExists(LocalizationSettingNames.DefaultLanguage, "en");
        }

        private void AddSettingIfNotExists(string name, string value, int? tenantId = null)
        {
            if (_context.Settings.IgnoreQueryFilters().Any(s => s.Name == name && s.TenantId == tenantId && s.UserId == null))
            {
                return;
            }

            _context.Settings.Add(new Setting(tenantId, null, name, value));
            _context.SaveChanges();
        }
    }
}
