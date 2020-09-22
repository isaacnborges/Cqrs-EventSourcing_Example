using CqrsEsExample.Core.DomainObjects;
using System;

namespace CqrsEsExample.Core.Data
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        IUnitOfWork UnitOfWork { get; }
    }
}

