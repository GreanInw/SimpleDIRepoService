using SimpleDI.Training.DbContexts.Bases;

namespace SimpleDI.Training.Repositories.Bases
{
    internal abstract class BaseRepository<TInterfaceDbContext, TEntity> : IRepository<TEntity>
        where TInterfaceDbContext : IDbContext
        where TEntity : class
    {
        public BaseRepository(TInterfaceDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected TInterfaceDbContext DbContext { get; }

        public void Add(TEntity entity) { }
        public void AddRange(IEnumerable<TEntity> entities) { }
        public void Edit(TEntity entity) { }
        public void Delete(TEntity entity) { }
    }
}