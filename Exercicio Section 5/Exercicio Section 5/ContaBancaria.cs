using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Section_5
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double SaldoDaConta { get; private set; }

        public ContaBancaria(int numeroDaConta, string nomeDoTitular, double depositoInicial)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
            SaldoDaConta = depositoInicial;
        }
        public ContaBancaria(int numeroDaConta, string nomeDoTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
            SaldoDaConta = 0;
        }

        public void Deposito(double valor)
        {
            SaldoDaConta = SaldoDaConta + valor;
        }
        public void Saque(double valor)
        {
            SaldoDaConta = SaldoDaConta - (valor + 5.0);
        }
    }
}
