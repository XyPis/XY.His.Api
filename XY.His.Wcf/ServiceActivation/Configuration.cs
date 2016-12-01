using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Reflection;
using XY.His.Contract.Service;
using XY.His.Core;
using XY.His.Utils.AutoMapper;
using XY.His.Utils.Unity;
using XY.His.Service;
using XY.His.Utils;
using log4net;

namespace XY.His.Server.ServiceActivation
{
    public class Configuration
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private const string ConnectionString = "HIS";

        public static void Configure()
        {
            Initializer.Init(ConnectionString, new Type[] { });

            LoadAllServiceTypes();
            SetHostFactory();
        }

        private static void LoadAllServiceTypes()
        {
            foreach (string assembly in ServiceConfig.Assemblies)
            {
                var serviceAssembly = Assembly.Load(assembly);

                var types = serviceAssembly.GetTypes();

                ServiceConfig.ServiceTypes = types
                    .Where(x => x.IsClass)
                    .Where(x => TypeHelper.IsDerivedOfGenericType(x, typeof(AbstractService<,>)))                    
                    .OrderBy(x => x.Name)
                    .ToArray();               
            }
        }

        private static void SetHostFactory()
        {
            var assembly = typeof(Configuration).Assembly;
            var types = assembly.GetTypes();
            var hostFactory = types.Where(x => typeof(System.ServiceModel.Activation.ServiceHostFactory).IsAssignableFrom(x));
            if (hostFactory == null || hostFactory.Count() == 0)
            {
                string errMsg = "No customize service host factory was found.";
                Log.Error(errMsg);

                throw new Exception(errMsg);
            }

            ServiceConfig.HostFactoryType = hostFactory.FirstOrDefault();
        }
    }
}