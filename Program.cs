using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N)");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'S')
            {
                Console.Write("Digite valor deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, nome);
            }
            Console.WriteLine("\n Dados da conta: ");
            Console.WriteLine(conta);
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados atualizados:");
            conta.Deposito(quantia);
            Console.WriteLine(conta);
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados atualizados:");
            conta.Saque(quantia);
            Console.WriteLine(conta);
            Console.WriteLine("Tenha um bom dia");
        }
    }
}
