using System;
using System.Collections.Generic;
using Xunit;
using System.Reflection;
using System.Linq;
using XY.His.Domain.BS;
using XY.His.Contract.Message.BS;
using XY.His.Service.BS;
using XY.His.Service.UnitTests.BS;

namespace UnitTestProject2
{
    public class CheckMissingClass
    {
        IList<string> missingDtos = new List<string>();
        IList<string> missingContracts = new List<string>();
        IList<string> missingServices = new List<string>();
        IList<string> missingUnitTests = new List<string>();

        [Fact]
        [Trait("01 CheckMissingClass", "01 CheckMissingClass")]
        public void Check()
        {
            Assembly entityAssembly = typeof(BsUser).Assembly;
            Assembly dtoAssembly = typeof(BsUserDto).Assembly;
            Assembly serviceAssembly = typeof(BSDoctorService).Assembly;
            Assembly unitTestsAssembly = typeof(BSDoctorServiceUnitTest).Assembly;

            var types = entityAssembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(XY.His.Domain.EntityBase)));

            foreach(Type type in types)
            {
                string dtoType = string.Format("{0}Dto", type.Name);
                string serviceType = string.Format("{0}Service", type.Name);
                string contractType = string.Format("I{0}", serviceType);
                string unitTestType = string.Format("{0}UnitTest", serviceType);

                var dtos = dtoAssembly.GetTypes()
                    .Where(x => x.IsSubclassOf(typeof(XY.His.Contract.DtoBase)))
                    .Where(x => x.Name.ToLower() == dtoType.ToLower()).ToList();

                var contracts = dtoAssembly.GetTypes()                    
                    .Where(x => x.Name.ToLower() == contractType.ToLower()).ToList();
                 
                var services = serviceAssembly.GetTypes()                    
                    .Where(x => x.Name.ToLower() == serviceType.ToLower()).ToList();

                var unitTests = unitTestsAssembly.GetTypes()                    
                    .Where(x => x.Name.ToLower() == unitTestType.ToLower()).ToList();

                if (dtos.Count == 0) 
                {
                    missingDtos.Add(dtoType);
                }

                if (contracts.Count == 0)
                {
                    missingContracts.Add(contractType);
                }

                if (services.Count == 0)
                {
                    missingServices.Add(serviceType);
                }

                if (unitTests.Count == 0)
                {
                    missingUnitTests.Add(unitTestType);
                }
            }

            Assert.Equal(0, missingDtos.Count);
            Assert.Equal(0, missingContracts.Count);
            Assert.Equal(0, missingServices.Count);
            Assert.Equal(0, missingUnitTests.Count);
        }
    }
}
