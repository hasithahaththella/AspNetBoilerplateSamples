using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AcmeCorp.Localization
{
    public static class AcmeCorpLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AcmeCorpConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AcmeCorpLocalizationConfigurer).GetAssembly(),
                        "AcmeCorp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
