using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace bysj.EntityFramework.Repositories
{
    public abstract class bysjRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<bysjDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected bysjRepositoryBase(IDbContextProvider<bysjDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class bysjRepositoryBase<TEntity> : bysjRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected bysjRepositoryBase(IDbContextProvider<bysjDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
