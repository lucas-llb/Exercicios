using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimulaCovid.Classes
{
    public static class Parametros
    {
        public static char CaracterePSaudavel { get; set; }
        public static char CaracterePInfectada { get; set; }
        public static int Tempo { get; set; }
        
        private static string QtdEstadosPer()
        {
            Console.WriteLine("Quantos estados deseja monitorar?");
            var resp = Console.ReadLine();
            return resp;
        }

        private static string QtdPessoasPer()
        {
            Console.WriteLine("Quantas pessoas deseja monitorar?");
            var resp = Console.ReadLine();
            return resp;
        }

        private static void Erro(this string erro)
        {
            Console.WriteLine(erro);
        }
        private static bool ENumero(string valida)
        {
            bool enumero = false;
            try
            {
                int numero = Convert.ToInt32(valida);
                enumero = true;
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Erro("Digite um número.. otário!");
                Console.ResetColor();
                enumero = false;
                Thread.Sleep(1000);
            }
            return enumero;
        }
        private static int QuestSecundario()
        {
            bool validapes = false;
            int qtdPes=0;
            do
            {
                string qtdPessoas = QtdPessoasPer();
                validapes = ENumero(qtdPessoas);
                if (validapes)
                {
                    qtdPes = Convert.ToInt32(qtdPessoas);
                    if (qtdPes <= 0)
                    {
                        Erro("Vo encher sua cara de porrada!");
                        validapes = false;
                    }
                }
            } while (!validapes);
            return qtdPes;
        }
        public static (int,int) QuestInicial()
        {
            bool validaest = false;
            int qtdEst = 0;
            do
            {
                Console.Clear();
                string qtdEstados = QtdEstadosPer();
                validaest = ENumero(qtdEstados);
                if (validaest)
                {
                    qtdEst = Convert.ToInt32(qtdEstados);
                    if (qtdEst > 27)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Erro("No Brasil só tem 27 estados Brô!");
                        Console.ResetColor();
                        validaest = false;
                        Thread.Sleep(1000);
                    }
                    if (qtdEst < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Erro("Tá de sacangem irmão?");
                        Console.ResetColor();
                        validaest = false;
                        Thread.Sleep(1000);
                    }
                }
            } while (!validaest);

            int qtdPes = QuestSecundario();
            return (qtdEst, qtdPes);
        }

    }
}
