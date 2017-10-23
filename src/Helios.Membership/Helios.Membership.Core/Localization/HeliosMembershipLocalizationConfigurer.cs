using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Helios.Membership.Localization
{
    public static class HeliosMembershipLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    HeliosMembershipConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HeliosMembershipLocalizationConfigurer).GetAssembly(),
                        "Helios.Localization.Membership"
                    )
                )
            );
        }
    }
}