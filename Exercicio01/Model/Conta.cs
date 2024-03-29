﻿using System;

namespace Exercicio01.Model
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal valor);
        public abstract decimal Retirar(decimal valor);

    }
}
