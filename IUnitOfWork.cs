using System;
using System.Data.Entity;

namespace BaseEfDataLayer
{
    public interface IUnitOfWork<out TContext> 
        : IDisposable where TContext : DbContext
    {
        int Save();
        TContext Context { get; }
    }
}
