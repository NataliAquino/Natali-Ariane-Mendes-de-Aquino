//Natali Ariane Mendes de Aquino

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioML
{
    class InverteString
    {
        public void inverterTexto(){
            String frase = "";
            String fraseInvertida = "";

            Console.WriteLine("***Inversão de Texto***\n\n");

            Console.WriteLine("Informe a frase a ser invertida: ");
            frase = Console.ReadLine();
            
            //inverter a frase/palavra inserida
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                fraseInvertida += frase[i];
            }

            Console.WriteLine("\n\nA frase invertida é: " + fraseInvertida + "\n");

       }
    }
}
