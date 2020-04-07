using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string message) : base(message)
        {

        }
        public SaldoInsuficienteException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
