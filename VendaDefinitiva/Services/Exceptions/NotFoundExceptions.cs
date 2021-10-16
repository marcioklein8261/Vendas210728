using System;


namespace VendaDefinitiva.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message ) :base(message)
        {

        }
    }
}
