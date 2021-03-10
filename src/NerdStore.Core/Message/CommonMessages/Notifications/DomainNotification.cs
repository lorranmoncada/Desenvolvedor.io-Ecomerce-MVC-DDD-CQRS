using MediatR;
using System;

namespace NerdStore.Core.Message.CommonMessages.Notifications
{
    public partial class DomainNotification : Message, INotification
    {
        public DateTime TimeStamp { get; private set; }
        // DomainNotificationId para notificar o id da notificação  caso esteja ocorrendo multe threads
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public string Value { get; private set; }
        public int Version { get; private set; }

        public DomainNotification(string key, string value)
        {
            TimeStamp = DateTime.Now;
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
            Version = 1;
        }
    }
}
