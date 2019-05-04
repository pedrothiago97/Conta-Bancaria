using System;
using System.Globalization;


namespace ContaBancaria
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= (quantia + 5);
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + " Titular: "
                + Nome
                + " Saldo : R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
