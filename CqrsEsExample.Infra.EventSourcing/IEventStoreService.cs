using EventStore.ClientAPI;

namespace CqrsEsExample.Infra.EventSourcing
{
    public interface IEventStoreService
    {
        IEventStoreConnection GetConnection();
    }
}
