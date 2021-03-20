using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Message.CommonMessages.IntegrationEvents
{
    // Os eventos que herdam de IntegrationEvent não pertecem a ninguem eles são eventos que podem ser disparados por qualquer contexto por estar na cada do Core
    public class IntegrationEvent: Event
    {
    }
}
