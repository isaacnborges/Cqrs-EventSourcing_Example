using CqrsEsExample.Core.Messages;
using CqrsEsExample.Core.Messages.CommonMessages.DomainEvents;
using CqrsEsExample.Core.Messages.CommonMessages.Notifications;
using System.Threading.Tasks;

namespace CqrsEsExample.Core.Communication
{
    public interface IMediatorHandler
    {
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        Task PublicarEvento<T>(T evento) where T : Event;
        Task PublicarEventoDominio<T>(T evento) where T : DomainEvent;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
    }
}
