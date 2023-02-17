using OnionArchitecture.Data;


namespace OnionArchitecture.Service
{
    public interface IRepository<TEntity,TKey> where TEntity : BaseEntity<TKey>  where TKey:IEquatable<TKey>
    {

        IEnumerable<TEntity> GetAll();

        TEntity GetById(TKey id);

    }
}
