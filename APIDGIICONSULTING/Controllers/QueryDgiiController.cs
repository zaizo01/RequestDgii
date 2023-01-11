using Consulting.Interfaces;
using Consulting.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDGIICONSULTING.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryDgiiController : ControllerBase
    {
        private readonly IRequestDgiiService _dgiiService;

        public QueryDgiiController(IRequestDgiiService dgiiService)
        {
            _dgiiService = dgiiService;
        }

        [HttpPost("consutar-ncf")]
        [Consumes("application/x-www-form-urlencoded")]
        public ResponseQueryNCF ConsultNcf([FromForm] string ncf, [FromForm] string rnc)
        {
            return _dgiiService.ConsultNcf(ncf, rnc);
        }

        [HttpPost("consutar-rnc-contribuyente")]
        [Consumes("application/x-www-form-urlencoded")]
        public ResponseQueryRncTaxpayers ConsultRncTaxpayers([FromForm] string rnc)
        {
            return _dgiiService.ConsultRncTaxpayers(rnc);
        }

        [HttpPost("consutar-rnc-registrados")]
        [Consumes("application/x-www-form-urlencoded")]
        public ResponseQueryRncRegistered ConsultarRncRegistrados([FromForm] string rnc)
        {
            return _dgiiService.ConsultRncRegistered(rnc);
        }
    }
}
