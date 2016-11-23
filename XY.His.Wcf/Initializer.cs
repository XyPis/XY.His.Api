using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Reflection;
using log4net;
using System.Data.Entity;
using XY.His.Contract.Service;
using XY.His.Core;
using XY.His.Utils.AutoMapper;
using XY.His.Utils.Unity;
using XY.His.Service.Gbl;
using XY.His.Contract.Service.Gbl;

namespace XY.His.Wcf
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private const string ConnectionString = "HIS";

        public static void Init()
        {
            Core.Initializer.Init<XyDbContext>(ConnectionString);

            var fromAssembly = typeof(IGblSettingService).Assembly;
            var toAssembly = typeof(GblSettingService).Assembly;

            IoC.RegisterType(fromAssembly, toAssembly, new Type[] { });

            AutoMapperBootStrapper.Initialize(new Assembly[]
            {
                typeof(GblSettingService).Assembly
            });

            IoC.RegisterType<ICommandWrapper, CommandWrapper>();

            InitServiceConfig();
        }

        private static void InitServiceConfig()
        {
            ServiceConfig.ServicePrefix = Constants.ServicePrefix;
            ServiceConfig.ServiceSuffix = Constants.ServiceSuffix;
            ServiceConfig.ServicePathSeparator = Constants.ServicePathSeparator;            
            ServiceConfig.ContractPrefix = Constants.ContractPrefix;
            ServiceConfig.ServiceAssembly = new List<string>() { Constants.ServiceAssembly };
            ServiceConfig.ServiceHostDebug = Constants.ServiceHostDebug;
            ServiceConfig.ServiceHostFactory = Constants.ServiceHostFactory;
            ServiceConfig.ServiceHostDefinition = Constants.ServiceHostDefinition;
            ServiceConfig.ServiceTypes = new Dictionary<string, Type>();

            foreach (string assembly in ServiceConfig.ServiceAssembly)
            {                
                var serviceAssembly = Assembly.Load(assembly);
                var types = serviceAssembly.GetTypes()
                    .Where(x => x.IsClass)
                    .Where(x => IsDerivedOfGenericType(x, typeof(XY.His.Service.AbstractService<,>)))
                    .OrderBy(x => x.Name);

                foreach (Type type in types)
                {
                    ServiceConfig.ServiceTypes.Add(type.Name, type);
                }
            }
        }

        static bool IsDerivedOfGenericType(Type type, Type genericType)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericType)
                return true;

            if (type.BaseType != null)
            {
                return IsDerivedOfGenericType(type.BaseType, genericType);
            }
            return false;
        }
    }
}