﻿using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Don.SportsStoreCore.Localization
{
    public static class SportsStoreCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SportsStoreCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SportsStoreCoreLocalizationConfigurer).GetAssembly(),
                        "Don.SportsStoreCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}