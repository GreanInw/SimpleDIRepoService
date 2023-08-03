namespace SimpleDI.Training.Repositories.Bases
{
    internal interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Edit(TEntity entity);
        void Delete(TEntity entity);
    }
}
