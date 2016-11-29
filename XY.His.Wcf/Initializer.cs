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
            XY.His.Service.Initializer.Init(ConnectionString, new Type[] { });

            InitizlizeServiceConfig();
        }

        private static void InitizlizeServiceConfig()
        {            
            foreach (string assembly in ServiceConfig.Assemblies)
            {                
                var serviceAssembly = Assembly.Load(assembly);

                var types = serviceAssembly.GetTypes();

                ServiceConfig.ServiceTypes = types
                    .Where(x => x.IsClass)
                    .Where(x => IsDerivedOfGenericType(x, typeof(XY.His.Service.AbstractService<,>)))
                    .OrderBy(x => x.Name)
                    .ToArray();               
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