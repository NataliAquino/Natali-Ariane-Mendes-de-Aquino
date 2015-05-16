//Natali Ariane Mendes de Aquino

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioML
{
    class Moedas
    {
        public void encontrarMoedaMaisPesada()
        {
            int[] pilhaA = new int[4];
            int[] pilhaB = new int[4];
            int[] pilhaC = new int[2];
            int[] pilhaD = new int[2];
            int pilhaE = 0;
            int pilhaF = 0;
            int pesoPilhaA = 0, pesoPilhaB = 0;
            int pilhaSort;
            int moedaPesada;
            int combinacoes = 0;
            int pesoPadrao;

            Console.WriteLine("***Encontrar o numero de combinações possível***\n\n");

            do
            {
                Random rand = new Random();

                Console.WriteLine("Digite o peso da moeda mais pesada: ");
                moedaPesada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o peso do restante das moedas: ");
                pesoPadrao = Convert.ToInt32(Console.ReadLine());

                // sorteando em qual das duas pilhas ficará a moeda mais pesada
                pilhaSort = (rand.Next(1, int.MaxValue) % 2);
                if (pilhaSort == 0)     //  irá para a primeira pilha
                {
                    pilhaA[0] = moedaPesada;
                }
                else
                {
                    pilhaB[0] = moedaPesada;
                }
                combinacoes++; // houve uma combinaçao


                // pesando as duas pilhas de moedas
                for (int i = 0; i < pilhaA.Length; i++)
                {
                    pesoPilhaA += pilhaA[i];
                    pesoPilhaB += pilhaB[i];
                }

                // verificando qual das duas pilhas é a mais pesada   se for a pilhaA, ela sera quebrada
                // em 2 arrays ou seja, 2 pilhas de 2 moedas. Caso contrario, o mesmo sera feita com a pilhaB
                if (pesoPilhaA > pesoPilhaB)
                {
                    pilhaC[0] = pilhaA[0];
                    pilhaC[1] = pilhaA[1];

                    pilhaD[0] = pilhaA[2];
                    pilhaD[1] = pilhaA[3];
                }
                else
                {
                    pilhaC[0] = pilhaB[0];
                    pilhaC[1] = pilhaB[1];

                    pilhaD[0] = pilhaB[2];
                    pilhaD[1] = pilhaB[3];
                }
                combinacoes++; // houve uma combinaçao


                pesoPilhaA = 0; pesoPilhaB = 0;
                // pesando  qual das duas novas
                // pilhas de 2 moedas é a mais pesada
                for (int i = 0; i < pilhaC.Length; i++)
                {
                    pesoPilhaA += pilhaC[i];
                    pesoPilhaB += pilhaD[i];
                }

                // a pilha que contem a moeda mais pesada será
                // quebrada em 2 pilhas de 1 moeda
                if (pesoPilhaA > pesoPilhaB)
                {
                    pilhaE = pilhaC[0];
                    pilhaF = pilhaC[1];
                }
                else
                {
                    pilhaE = pilhaD[0];
                    pilhaF = pilhaD[1];
                }
                combinacoes++; // houve uma combinaçao

                Console.WriteLine("Numero de combinações minimas: " + combinacoes);
                Console.ReadKey();          // PAUSA
            } while (true);


        }
    }
}
    