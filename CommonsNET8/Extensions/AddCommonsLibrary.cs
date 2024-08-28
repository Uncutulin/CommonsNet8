﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace CommonsNET8.Extensions
{
    public static partial class Extensions
    {
        public static void AddCommonsLibraryViews(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.FileProviders.Add(new EmbeddedFileProvider(typeof(CommonsNET8.ViewComponents.RegisterCommonsOnlineViewComponent)
                    .GetTypeInfo().Assembly));
                options.FileProviders.Add(new EmbeddedFileProvider(typeof(Class1)
                    .GetTypeInfo().Assembly));
            });
        }

        public static void UseCommonsLibraryScripts(this IApplicationBuilder builder)
        {
            var embeddedProvider = new EmbeddedFileProvider(typeof(CommonsNET8.ViewComponents.RegisterCommonsOnlineViewComponent)
                .GetTypeInfo().Assembly, "CommonsNET8.wwwroot.js");

            builder.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = embeddedProvider,
                RequestPath = new PathString("/js")
            });

            embeddedProvider = new EmbeddedFileProvider(typeof(CommonsNET8.ViewComponents.RegisterCommonsOnlineViewComponent)
                .GetTypeInfo().Assembly, "CommonsNET8.wwwroot.css");

            builder.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = embeddedProvider,
                RequestPath = new PathString("/css")
            });

            embeddedProvider = new EmbeddedFileProvider(typeof(Class1)
                .GetTypeInfo().Assembly, "CommonsUI.wwwroot.js");

            builder.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = embeddedProvider,
                RequestPath = new PathString("/js")
            });

            embeddedProvider = new EmbeddedFileProvider(typeof(Class1)
                .GetTypeInfo().Assembly, "CommonsUI.wwwroot.css");

            builder.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = embeddedProvider,
                RequestPath = new PathString("/css")
            });
        }
    }


}
