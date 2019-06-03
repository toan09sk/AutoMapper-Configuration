using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using AutoMapper;
using AutoMapperConfiguration.Profiles;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace AutoMapperConfiguration.App_Start
{
    public static class ComponentsRegistration
    {
        public static void RegisterComponents()
        {
            var config = new AutoMapper.MapperConfiguration(c => {
                c.AddProfile(new ApplicationProfile());
            });

            var mapper = config.CreateMapper();

            var container = new Container();
            container.RegisterSingleton<IMapper>(()=>mapper);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}