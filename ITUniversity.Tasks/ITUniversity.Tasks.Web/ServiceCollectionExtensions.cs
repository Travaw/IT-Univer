using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITUniversity.AspNetCore;
using ITUniversity.Tasks.Application;
using ITUniversity.Tasks.Application.Services;
using ITUniversity.Tasks.Application.Services.Imps;
using ITUniversity.Tasks.Managers;
using ITUniversity.Tasks.Managers.Impls;
using ITUniversity.Tasks.NHibernate;
using ITUniversity.Tasks.NHibernate.Repositories;
using ITUniversity.Tasks.Repositories;
using ITUniversity.Tasks.Stores;

using Microsoft.Extensions.DependencyInjection;

using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace ITUniversity.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskStore, TaskDbStore>();
            services.AddTransient<ITaskManager, TaskManager>();
            services.AddTransient<IUserManager, UserManager>();
            services.AddTransient<IUserAppService, UserAppService>();
            services.AddTransient<IRoleAppService, RoleAppService>();
            return services;
        }

        public static IServiceCollection AddTaskApplicationServices(this IServiceCollection services)
        {
            services.CreateControllersForAppServices(typeof(TaskApplicationModule).Assembly);
            services.AddTransient<ITaskAppService, TaskAppService>();

            return services;
        }

        public static IServiceCollection AddTaskNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(TaskNhibernateModule).Assembly.ExportedTypes);
            var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = connectionString;
                //c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                //c.SchemaAction = SchemaAutoAction.Validate;
                //c.LogFormattedSql = true;
                //c.LogSqlInConsole = true;
            });
            configuration.AddMapping(mappings);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddTransient<ITaskRepository, TaskRepository>();
            //services.AddScoped<IMapperSession, NHibernateMapperSession>();

            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            return services;
        }
    }
}
