namespace Exercicio01.Model
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
                Saldo -= valor;
            }
            return valor;

        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }
    }
}
