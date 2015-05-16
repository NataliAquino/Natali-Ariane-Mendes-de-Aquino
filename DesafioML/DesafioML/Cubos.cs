//Natali Ariane Mendes de Aquino


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioML
{
    class Cubos
    {
        public void calcularFacesPintadas()
        {
            int arestaComprimento = 8;
            int totalMiniCubosPintados = 0;

            Console.WriteLine("***Quantos mini cubos terão pelo menos uma face pintada***\n\n");

            // Quantidade de mini cubos pintados por face
            totalMiniCubosPintados = arestaComprimento * arestaComprimento;

            Console.WriteLine("Mini cubos com pelo menos uma face pintada: " + totalMiniCubosPintados + "\n");
            
        }
    }
}
