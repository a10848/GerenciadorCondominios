using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorCondominios.Extensions
{
    public static class ConfiguracaoCookiesExtension
    {
        public static void ConfigurarCookis(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(opcoes =>
            {
                opcoes.Cookie.Name = "IdentifyCookie";
                opcoes.Cookie.HttpOnly = true;
                opcoes.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                opcoes.LoginPath = "/Usuarios/Login";
            });
        }
    }
}
