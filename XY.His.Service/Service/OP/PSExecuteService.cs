using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.Transactions;
using System.Linq.Expressions;
using System.Data.Objects.SqlClient;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using log4net;
using XY.His.Contract.Message.OP;
using XY.His.Contract.Service.OP;
using XY.His.Domain.OP;

namespace XY.His.Service.OP
{
    public class PSExecuteService : AbstractService<PsExecute, PsExecuteDto>, IPSExecuteService
    {       
    }
}
