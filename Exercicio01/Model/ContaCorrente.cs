namespace Exercicio01.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }
        public override void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo - valor < 0)
            {
                valor = 0;
                throw new SaldoInsuficienteException("Retirada na Corrente negada");
            }
            else
            {
                Saldo -= valor;
            }
            return valor;

        }
    }
}
