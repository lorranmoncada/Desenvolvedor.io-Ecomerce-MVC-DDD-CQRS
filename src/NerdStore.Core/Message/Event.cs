using MediatR;
using System;

namespace NerdStore.Core.Message
{
    //Todo evento sera entrege atraves de um ferramenta um mediator - ps: é necessário instalar um package chamado MediatR no projeto domain do contexto e no projeto core
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
