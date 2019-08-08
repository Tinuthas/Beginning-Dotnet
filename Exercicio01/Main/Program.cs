using Exercicio01.Model;
using System;

namespace Exercicio01.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca(Convert.ToDecimal(4.5));

            try
            {
                cc.Depositar(600);
                cc.Retirar(700);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.ShowMessage);
            }

            try
            {
                cp.Depositar(600);
                cp.Retirar(700);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.ShowMessage);
            }
        }
    }
}
