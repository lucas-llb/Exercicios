using System;
using System.Collections.Generic;
using System.Text;

namespace SimulaCovid.Classes
{
    public class Calculo : Monitoramento
    {
        public static (int, int) CaculoPosicao(int qtdlinha, int qtdcoluna)
        {
            var random = new Random();
            //int total = qtdlinha * qtdcoluna;
            //int posicao = random.Next(0, total+1);
            int poslinha = random.Next(1, qtdlinha+1);
            int poscoluna = random.Next(1,qtdcoluna+1);
            //if (posicao > qtdcoluna)
            //{
            //    while (posicao > qtdcoluna)
            //    {
            //        posicao -= qtdcoluna;
            //        poslinha++;
            //    }
            //    poscoluna = posicao;
            //}
            //else
            //{
            //    poscoluna = posicao;
            //    poslinha = 0;
            //}
                        
            return (poslinha, poscoluna);
        }
        
    }
}
