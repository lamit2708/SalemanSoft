using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.SqlServer.Methods;
using VSoft.Company.CTM.Customer.Business.Provider.Services;
using VSoft.Company.CTM.Customer.Business.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Repository.Services;
using VSoft.Company.CTM.Customer.Repository.Efc.Provider.Services;

namespace VSoft.Company.CTM.Customer.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<CustomerDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseSqlServer(cfg, configuration);
            });
            services.AddScoped<ICustomerRepository, EfcCustomerRepository>();
            services.AddScoped<ICustomerMgmtBus, CustomerMgmtBus>();
           
        }
    }
}
