using Exercicio01.Exceptions;
using Exercicio01.Model;

namespace Exercicio01.Banco.Model
{

    //sealed -> a classe não pode ser herdada
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo - valor < 0 && Tipo == TipoConta.Comum)
            {
                valor = 0;
                throw new SaldoInsuficienteException("Retirada na Corrente negada");
            }
            Saldo -= valor;
            
            return valor;

        }
    }
}
