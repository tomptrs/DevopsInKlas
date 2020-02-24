using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using LBI_DAL.Helpers; 

namespace LBI_DAL
{
    public static class ServiceCollectionDAL
    {
        public static void AddServiceCollectionDAL(this IServiceCollection services)
        {
            services.AddScoped<IAgenda_DAL, Agenda_DAL>(); 
            services.AddScoped<IGoals_DAL, Goals_DAL>();
            services.AddScoped<IExterne_bron_DAL, Externe_bron_DAL>();
            services.AddScoped<IQuotes_DAL, Quotes_DAL>();
            services.AddScoped<ICategory_DAL, Category_DAL>();
            services.AddScoped<IHappiness_DAL, Happiness_DAL>();
            services.AddScoped<IEigenNetwerk_DAL, EigenNetwerk_DAL>();
            services.AddScoped<IMindfulness_DAL, Mindfulness_DAL>();
            services.AddScoped<IMomentKader_DAL, MomentKader_DAL>();
            services.AddScoped<IUsers_DAL, Users_DAL>();
            services.AddScoped<IStats_DAL, Stats_DAL>(); 
            LBIContext context;
            DBInitializer.Initialize(context = new LBIContext()); 
        }
    }
}
