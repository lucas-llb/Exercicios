using System;

namespace Exercicio_Section_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDaConta = 0;
            string titular = "";
            string perguntaDeposito = "";
            double depositoInicial = 0;
            ContaBancaria Cliente;
            Console.WriteLine("Entre com o número da conta: ");
            numeroDaConta =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            titular = Console.ReadLine();
            do
            {
                Console.WriteLine("Haverá depósito indicial(s/n): ");
                perguntaDeposito = Console.ReadLine().ToLower();
            } while (perguntaDeposito != "s" && perguntaDeposito != "n");
            if(perguntaDeposito == "s")
            {
                Console.WriteLine("Entre com o valor para depósito inicial: ");
                depositoInicial = Convert.ToDouble(Console.ReadLine());
                Cliente = new ContaBancaria(numeroDaConta, titular, depositoInicial);
            }
            else
            {
                Cliente = new ContaBancaria(numeroDaConta, titular);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine($"Conta: {Cliente.NumeroDaConta}, Titular: {Cliente.NomeDoTitular}, Saldo: {Cliente.SaldoDaConta:F}");
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para depósito: ");
            Cliente.Deposito(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine($"Conta: {Cliente.NumeroDaConta}, Titular: {Cliente.NomeDoTitular}, Saldo: {Cliente.SaldoDaConta:F}");
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            Cliente.Saque(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine($"Conta: {Cliente.NumeroDaConta}, Titular: {Cliente.NomeDoTitular}, Saldo: {Cliente.SaldoDaConta:F}");

            Console.ReadKey();
        }
    }
}
