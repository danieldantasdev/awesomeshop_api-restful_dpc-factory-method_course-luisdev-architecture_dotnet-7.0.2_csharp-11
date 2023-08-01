using FactoryMethod.Application.Models;
using FactoryMethod.Core.Services.Interfaces;

namespace FactoryMethod.Application.Services.Implementations;

public class PaymentSlipService : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        return "Dados do boleto.";
    }
}