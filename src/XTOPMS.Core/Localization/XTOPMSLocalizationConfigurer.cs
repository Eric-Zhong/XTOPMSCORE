using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace XTOPMS.Localization
{
    public static class XTOPMSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(XTOPMSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(XTOPMSLocalizationConfigurer).GetAssembly(),
                        "XTOPMS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
