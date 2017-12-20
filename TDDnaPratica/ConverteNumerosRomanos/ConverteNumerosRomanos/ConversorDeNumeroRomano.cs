using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteNumerosRomanos
{
   
    public class ConversorDeNumeroRomano
    {


        public int Converte(string numeroRomano)
        {
            int acumulador = 0;
            int ultimoVizinhoDaDireita = 0;
            for (int i = numeroRomano.Length-1;i>=0;i--)
            {
                //pega o inteiro referente ao simbolo atual
                int atual = tabela[numeroRomano[i]];

                // se o da direita for menor, o multiplicaremos
                // por -1 para torná-lo negativo
                int multiplicador = 1;

                if (atual < ultimoVizinhoDaDireita) multiplicador = -1;
                    acumulador += atual*multiplicador;

                // atualiza o vizinho da direita 
                ultimoVizinhoDaDireita = atual;
            }

            return acumulador;
        }


        private static Dictionary<char, int> tabela =
            new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
    }
}
