using Microsoft.Extensions.DependencyInjection;
using Contrib.Extensions.Configuration;

namespace remittance.api.Configuration
{
    public static class ApplicationSettings
    {
        public static void AddSettings(this IServiceCollection services)
        {
            // Uses AutoBind and SubstituteVariables from https://github.com/drwatson1/configuration-extensions project
            //services.AddOptions<Settings.Branch>()
            //    .AutoBind()
            //    .SubstituteVariables();
            services.AddOptions<Settings.Branch>()
                .AutoBind();
        }
    }
}
