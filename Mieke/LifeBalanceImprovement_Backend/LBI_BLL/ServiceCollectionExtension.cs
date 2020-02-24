using System;
using System.Collections.Generic;
using System.Text;
using LBI_BLL.Helpers;
using LBI_DAL;
using Microsoft.Extensions.DependencyInjection;

namespace LBI_BLL
{
    public static class ServiceCollectionExtension
    {
        public static void AddServiceCollection(this IServiceCollection services)
        {
            services.AddScoped<IAgenda_BLL, Agenda_BLL>(); 
            services.AddScoped<IGoals_BLL, Goals_BLL>();
            services.AddScoped<IExterne_bron_BLL, Externe_bron_BLL>();
            services.AddScoped<IQuotes_BLL, Quotes_BLL>();
            services.AddScoped<ICategory_BLL, Category_BLL>();
            services.AddScoped<IHappiness_BLL, Happiness_BLL>();
            services.AddScoped<IEigenNetwerk_BLL, EigenNetwerk_BLL>();
            services.AddScoped<IMindfulness_BLL, Mindfulness_BLL>();
            services.AddScoped<IMomentKader_BLL, MomentKader_BLL>();
            services.AddScoped<IUsers_BLL, User_BLL>();
            services.AddScoped<IStats_BLL, Stats_BLL>(); 
            services.AddServiceCollectionDAL(); 
        }
    }
}
