using SimpleDI.Training.Repositories.Sales;

namespace SimpleDI.Training.Services.Sales.SaleOrders
{
    internal class SaleOrderService : ISaleOrderService
    {
        private readonly ISaleOrderRepository _saleOrderRepository;

        public SaleOrderService(ISaleOrderRepository saleOrderRepository)
        {
            _saleOrderRepository = saleOrderRepository;
        }

        public ValueTask<object> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    internal interface ISaleOrderService
    {
        ValueTask<object> GetByIdAsync(Guid id);
    }
}
