using System;

namespace Exercicio01.Exceptions
{
    class SaldoInsuficienteException : Exception
    {
        public String ShowMessage { get; set; }
        public SaldoInsuficienteException(String message)
        {
            ShowMessage = message;
        }
    }
}
