using FactoryMethod.Application.Models;

namespace FactoryMethod.Core.Services.Interfaces
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}