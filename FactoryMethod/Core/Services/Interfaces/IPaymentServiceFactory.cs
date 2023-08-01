using FactoryMethod.Core.Enums;

namespace FactoryMethod.Core.Services.Interfaces;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}