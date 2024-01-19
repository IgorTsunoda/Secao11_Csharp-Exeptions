using System;

namespace ExcessaoPersonalizadaExercicio.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
