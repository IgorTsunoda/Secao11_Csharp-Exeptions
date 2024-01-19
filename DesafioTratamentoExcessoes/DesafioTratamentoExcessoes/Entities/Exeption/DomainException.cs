using System;

namespace DesafioTratamentoExcessoes.Entities.Exeption
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
