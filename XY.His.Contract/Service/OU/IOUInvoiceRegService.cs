using System;
using System.Collections.Generic;
using System.Text;
using XY.His.Contract.Message.OU;

namespace XY.His.Contract.Service.OU
{
    public interface IOUInvoiceRegService : IService<OulInvoiceRegDto>
    {
        IEnumerable<OulInvoiceRegDto> GetByMzRegId(int mzRegId);
    }
}
