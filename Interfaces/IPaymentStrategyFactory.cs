namespace ProvaPub.Interfaces
{
    public interface IPaymentStrategyFactory
    {
        IPaymentStrategy Create(string paymentMethod);
    }
}