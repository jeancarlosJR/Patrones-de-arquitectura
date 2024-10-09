﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extension.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindServices(
        this IServiceCollection services)
    {
        services.AddDebugwriter();
        services.AddServices();
        return services;
    }

}
