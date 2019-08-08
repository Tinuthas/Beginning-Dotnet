using System;

namespace Exercicio01.Model
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
