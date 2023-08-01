using FactoryMethod.Application.Models;
using FactoryMethod.Core.Services.Interfaces;

namespace FactoryMethod.Application.Services.Implementations;

public class PaymentCreditCardService : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        return "Transaçao aprovada.";
    }
}