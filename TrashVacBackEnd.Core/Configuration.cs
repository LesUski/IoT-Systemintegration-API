﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using TrashVacBackEnd.Core.Configurations;

namespace TrashVacBackEnd.Core
{
    public class Configuration 
    {
        public Configuration(IConfigurationBuilder builder)
        {
            var configuration = builder.Build();
            ConnectionStrings = new ConnectionStringsConfiguration(configuration);
            SiteSettings = new SiteSettingsConfiguration(configuration);
        }

        public ConnectionStringsConfiguration ConnectionStrings { get; set; }
        public SiteSettingsConfiguration SiteSettings { get; set; }
    }
}
