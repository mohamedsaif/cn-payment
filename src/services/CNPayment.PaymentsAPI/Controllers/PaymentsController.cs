using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CNPayment.PaymentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly ILogger<PaymentsController> _logger;

        public PaymentsController(ILogger<PaymentsController> logger)
        {
            _logger = logger;
        }


    }
}
