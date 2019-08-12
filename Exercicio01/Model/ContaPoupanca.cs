using Exercicio01.Exceptions;

namespace Exercicio01.Model.Banco
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;
        public decimal Taxa { get; set; }

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo - valor < 0)
            {
                valor = 0;
                throw new SaldoInsuficienteException("Retirada na Poupança negada");
            }
            else
            {
                Saldo -= valor + Taxa;
            }
            return valor + Taxa;

        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }
    }
}
