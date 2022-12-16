using BasvuruUygulamasi.Business.Abstract;
using BasvuruUygulamasi.Business.Concrete;
using BasvuruUygulamasi.DataAccess.Abstract;
using BasvuruUygulamasi.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasvuruUygulamasi.Business.DependencyResolvers.Microsoft
{
    public static class BusinessServices
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {

            services.AddScoped<IPersonelService,PersonelManager>();
            services.AddScoped<IPersonelDal, EfPersonelDal>();

            services.AddScoped<ISehirService, SehirManager>();
            services.AddScoped<ISehirDal, EfSehirDal>();

            services.AddScoped<IIlceService, IlceManager>();
            services.AddScoped<IIlceDal, EfIlceDal>();

            services.AddScoped<IPersonelIsBasvurusuService, PersonelIsBasvurusuManager>();
            services.AddScoped<IPersonelIsBasvurusuDal, EfPersonelIsBasvurusuDal>();
        }

       

        
        
        

        
    }
}
