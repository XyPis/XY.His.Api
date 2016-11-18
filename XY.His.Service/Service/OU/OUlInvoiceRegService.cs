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
using XY.His.Contract.Message.OU;
using XY.His.Contract.Service.OU;
using XY.His.Domain.OU;

namespace XY.His.Service.OU
{
    public class OUlInvoiceRegService : AbstractService<OulInvoiceReg, OulInvoiceRegDto>, IOUlInvoiceRegService
    {
    }
}
