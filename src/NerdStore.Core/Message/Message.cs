using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Message
{
    // Classe base para messages
    public abstract class Message
    {
        public string MessageType { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            //GetType().Name estou retornando o nome da classe que esta implementando a classe Message
            MessageType = GetType().Name;
        }
    }
}
