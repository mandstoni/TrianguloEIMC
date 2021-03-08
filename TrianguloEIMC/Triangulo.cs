using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEIMC
{
    class Triangulo
    {
        static void Main(string[] args)
        {
            int[] ladosTriangulo = new int[3];

            for (int i = 0; i < ladosTriangulo.Length; i++)
            {
                Console.Write("informe o " + (i + 1) + " lado do triangulo:");
                ladosTriangulo[i] = int.Parse(Console.ReadLine());
            }

            if (ladosTriangulo[0] == ladosTriangulo[1] && ladosTriangulo[1] == ladosTriangulo[2])
            {
                Console.Write("\nÉ um triangulo Equilátero");
            }
            else if ((ladosTriangulo[0] == ladosTriangulo[1]) || (ladosTriangulo[1] == ladosTriangulo[2]) ||
               (ladosTriangulo[0] == ladosTriangulo[2]))
            {
                Console.Write("\nÉ um triângulo Isósceles");
            }
            else
            {
                Console.Write("\nÉ um triângulo Escaleno");
            }

            Console.ReadKey();
        }
    }
}
