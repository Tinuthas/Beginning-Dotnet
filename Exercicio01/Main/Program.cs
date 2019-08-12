using Exercicio01.Banco.Model;
using Exercicio01.Exceptions;
using Exercicio01.Model.Banco;
using System;

namespace Exercicio01.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 1, 
                Saldo = 100,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };
            ContaPoupanca cp = new ContaPoupanca(0.03m)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 100,
                DataAbertura = new DateTime(2019, 1, 20),
                Taxa = 1
            };

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
                Console.WriteLine("Retorno Investido é ${0}", cp.CalculaRetornoInvestimento());
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
