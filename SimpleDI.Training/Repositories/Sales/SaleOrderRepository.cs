using SimpleDI.Training.DbContexts;
using SimpleDI.Training.Models.Sales;
using SimpleDI.Training.Repositories.Bases;

namespace SimpleDI.Training.Repositories.Sales
{
    internal class SaleOrderRepository : BaseRepository<ISalesDbContext, SaleOrder>, ISaleOrderRepository
    {
        public SaleOrderRepository(ISalesDbContext dbContext) : base(dbContext) { }
    }

    internal interface ISaleOrderRepository : IRepository<SaleOrder> { }
}
