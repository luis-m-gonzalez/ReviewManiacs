using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ReviewManiacs.Localization
{
    public static class ReviewManiacsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ReviewManiacsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ReviewManiacsLocalizationConfigurer).GetAssembly(),
                        "ReviewManiacs.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
