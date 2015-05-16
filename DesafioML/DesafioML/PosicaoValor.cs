//Natali Ariane Mendes de Aquino

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioML
{
    class PosicaoValor
    {
        public void acharPosicaoDeUmValor()
        {
            int[] vetor = new int [10];
            int i, valorDoUsuario;

            Console.WriteLine("***Posição de um valor determinado***\n\n");
            Console.WriteLine("Insira os valores: ");

            for (i = 0; i < vetor.Length; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("Digite um valor para ser encontrado o indice: ");
            valorDoUsuario = int.Parse(Console.ReadLine());

            for (i = 0; i < vetor.Length; i++)
            {

                if (vetor[i] == valorDoUsuario)
                    Console.WriteLine("Este valor está no indice: " + i + "\n");
            }
         }
   }
}

