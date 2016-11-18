using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Microsoft.Practices.Unity;
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
            Core.Initializer.Init<XyDbContext>(connectionString);

            var fromAssembly = typeof(IGblSettingService).Assembly;
            var toAssembly = typeof(GblSettingService).Assembly;
            
            IoC.RegisterType(fromAssembly, toAssembly, excludeTypes);

            AutoMapperBootStrapper.Initialize(new Assembly[]
            {
                typeof(GblSettingService).Assembly
            });

            IoC.RegisterType<ICommandWrapper, CommandWrapper>();
        }
    }
}