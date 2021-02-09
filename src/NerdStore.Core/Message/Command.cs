using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Message
{
    // IRequest é uma interface do MediatR
    // O IRequest esta retornando um booleano
    // Classe abstract não posso chama-la diretamente preciso herda-la
    // ValidationResult é uma coleção de validações em formato de resultado
    public abstract class Command : Message, IRequest<bool>
    {
        public DateTime TimeStamp { get; private set; }
        // Validar meu comando, instalar o pacote FluentValidation
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
