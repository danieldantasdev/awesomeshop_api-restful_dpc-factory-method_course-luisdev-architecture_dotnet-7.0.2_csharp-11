using FactoryMethod.Application.Models;
using FactoryMethod.Core.Enums;
using FactoryMethod.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;

        public OrdersController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost("with-out-factory-method")]
        public IActionResult PostWithOutFactory(OrderInputModel model)
        {
            switch (model.PaymentInfo.PaymentMethod)
            {
                case PaymentMethod.CreditCard:
                    //Código de processar pagamento de cartão de crédito
                    break;
                case PaymentMethod.PaymentSlip:
                    //Código de processar pagamento de boleto e notificar cliente
                    break;
                default:
                    return BadRequest("Meio de pagamento não suportado.");
            }

            return NoContent();
        }

        [HttpPost("with-factory-method")]
        public IActionResult PostWithFactory(OrderInputModel model)
        {
            var paymentService = _paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);

            paymentService.Process(model);

            return NoContent();
        }
    }
}