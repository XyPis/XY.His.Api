using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using log4net;
using XY.His.Core;
using XY.His.Utils.Unity;
using XY.His.Utils.AutoMapper;
using XY.His.Contract.Service.Gbl;
using XY.His.Service.Gbl;

namespace XY.His.Service
{
    public class Initializer
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
        public static void Init(string connectionString, params Type[] excludeTypes)
        {
            XY.His.Core.EntityFramework.Initializer.Init<XyDbContext>(connectionString);

            var contractAssembly = typeof(XY.His.Contract.Service.IService<>).Assembly;
            var serviceAssembly = typeof(XY.His.Service.AbstractService<,>).Assembly;

            IoC.RegisterType(contractAssembly, serviceAssembly, excludeTypes);

            AutoMapperConfiguration.Initialize(serviceAssembly);

            IoC.RegisterType<ICommandWrapper, CommandWrapper>();
        }
    }
}