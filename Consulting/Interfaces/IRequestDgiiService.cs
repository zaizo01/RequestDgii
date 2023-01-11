using Consulting.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulting.Interfaces
{
    public interface IRequestDgiiService
    {
        ResponseQueryRncTaxpayers ConsultRncTaxpayers(string rnc);

        ResponseQueryRncRegistered ConsultRncRegistered(string rnc);

        ResponseQueryNCF ConsultNcf(string ncf, string rnc);
    }
}
