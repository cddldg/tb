using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TB.EntityFramework.Repositories
{
    public abstract class TBRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TBDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TBRepositoryBase(IDbContextProvider<TBDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TBRepositoryBase<TEntity> : TBRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TBRepositoryBase(IDbContextProvider<TBDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
