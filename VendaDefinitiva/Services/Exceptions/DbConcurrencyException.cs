using System;


namespace VendaDefinitiva.Services.Exceptions
{
    public class DbConcurrencyException :ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
