using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TogetherGame.Application.Interfaces.Services;

using TogetherGame.Identity.Data;
using TogetherGame.Identity.Services;

namespace TogetherGame.API.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<IdentityDataContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IIdentityService, IdentityService>();

        }
    }
}