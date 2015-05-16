//Natali Ariane Mendes de Aquino

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioML
{
    class Program
    {
        static void Main(string[] args)
        {
            InverteString invs = new InverteString();
            PosicaoValor pv = new PosicaoValor();
            Moedas md = new Moedas();
            Cubos cb = new Cubos();
            int opcao;

            do{
                Console.WriteLine("1. Moedas\n2. Cubos\n3. Posição Valor\n4. Inverter String\n5. Sair\nOpção: ");
                opcao = Convert.ToInt16( Console.ReadLine());
         
                switch (opcao)
                {
                    case 1:
                        md.encontrarMoedaMaisPesada();
                        break;
                    case 2:
                        cb.calcularFacesPintadas();
                        break;
                    case 3:
                        pv.acharPosicaoDeUmValor();
                        break;
                    case 4:
                        invs.inverterTexto();
                        break;
                    default:
                        break;
                }
            }while( opcao < 5 );
   
        }
    }
}
