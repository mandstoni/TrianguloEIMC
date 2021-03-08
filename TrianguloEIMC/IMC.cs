using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloEIMC
{
    class IMC
    {
        static void Main(string[] args) {
            double peso, altura, imc;
            int[] tableIMC ={18, 25, 30, 35, 40};

            Console.Write("Informe seu peso em kg:");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura em metros (exemplo:1,57");
            altura = double.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.Write("Seu IMC é: " + imc + "\n");


            if (imc <= tableIMC[0])
            {
                Console.Write("Peso baixo");
            }
            else if (imc > tableIMC[0] && imc <= tableIMC[1])
            {
                Console.Write("Peso normal");
            }
            else if (imc > tableIMC[1] && imc <= tableIMC[2])
            {
                Console.Write("Sobrepeso");
            }
            else if (imc > tableIMC[2] && imc <= tableIMC[3])
            {
                Console.Write("Obesidade");
            }
            else if (imc > tableIMC[3] && imc <= tableIMC[4])
            {
                Console.Write("Obesidade severa");
            }
            else if (imc > tableIMC[4])
            {
                Console.Write("Obesidade mórbida");
            }

            Console.ReadKey();
        }

    }
}
