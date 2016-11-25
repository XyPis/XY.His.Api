using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AutoMapper;

namespace XY.His.Utils.AutoMapper
{
    public sealed class AutoMapperConfiguration
    {
        public static void Initialize(Assembly profileAssembly)
        {
            Mapper.Initialize(cfg => 
            {
                cfg.AddProfiles(profileAssembly);
            });
            //Mapper.AssertConfigurationIsValid();
        }

        private static void AddProfile(IMapperConfigurationExpression config, Assembly[] assemblies)
        {
            foreach (Assembly assembly in assemblies)
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsAbstract || type.IsInterface)
                    {
                        continue;
                    }

                    if (typeof(Profile).IsAssignableFrom(type))
                    {
                        config.AddProfile(Activator.CreateInstance(type) as Profile);
                    }
                }
            }
        }
    }
}
