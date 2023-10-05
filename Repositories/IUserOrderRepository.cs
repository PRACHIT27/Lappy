namespace Lappy.Repositories
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> GetOrders();
    }
}