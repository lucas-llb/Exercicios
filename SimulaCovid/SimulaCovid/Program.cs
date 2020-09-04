using SimulaCovid.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimulaCovid
{
    class Program
    {
        static void Main(string[] args)
        {
            Parametros.CaracterePInfectada = '@';
            Parametros.CaracterePSaudavel = '*';
            Parametros.Tempo = 60;
            var numero = Parametros.QuestInicial();
            int qtdEst = numero.Item1;
            int qtdPes = numero.Item2;
            var monitora = new Monitoramento()
            {
                QtdEstados = qtdEst,
                QtdPessoas = qtdPes
            };
            //StringBuilder individuos = new StringBuilder(qtdPes);
            //var individuos = new string[qtdEst];
            //int contIndviduos = 0;
            var lista = new List<(int, int)>();
            for (int k = 0; k<Parametros.Tempo; k++)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Monitoramento COVID");
                var posicao = Calculo.CaculoPosicao(qtdEst, qtdPes);
                do
                {
                   posicao = Calculo.CaculoPosicao(qtdEst, qtdPes);

                } while (lista.Contains(posicao));
                lista.Add(posicao);
                for (int i = 1; i <= qtdEst; i++)
                {
                    if (i == posicao.Item1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                   Console.Write($"Estado {i} -> \t");
                    for (int j = 1; j <= qtdPes; j++)
                    {
                        bool saudavel = true;
                        foreach (var item in lista)
                        {
                            if (i == item.Item1 && j == item.Item2)
                            {
                                Console.Write(Parametros.CaracterePInfectada);
                                saudavel = false;
                            }
                            
                        }
                        if(saudavel)
                        {
                            Console.Write(Parametros.CaracterePSaudavel);
                        }
                    }
                    Console.WriteLine();
                }
                
            }


            Console.ReadKey();
        }
    }
}
