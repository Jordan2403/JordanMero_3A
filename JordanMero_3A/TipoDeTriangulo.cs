using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que lea tres números e indique el tipo de triángulo que forman
//(isósceles, equilatero, escaleno). Permitir que se pueda repetir indefinidamente
//si el usuario lo desea (que el ordenador pregunte ¿Quiere continuar? y la persona pueda responder S ó N) 
namespace JordanMero_3A
{
    internal class TipoDeTriangulo
    {
        public void main (string [] args) 
        {
            int numero1;
            int numero2;
            int numero3;

            Console.WriteLine ("Tipos de triangulo dependiendo en valor");
            Console.WriteLine();
            while (true) 
            {
                Console.WriteLine("ingrese el primer valor");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el primer valor");
                numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el primer valor");
                numero3 = Convert.ToInt32(Console.ReadLine());

                if (numero1 == numero2 && numero1 == numero3)
                {
                    Console.WriteLine("Es un triangulo EQUILATERO");
                }
                if (numero1 == numero2 && numero1 != numero3)
                {
                    Console.WriteLine("Es un trangulo ISOSCELES");
                }
                if (numero1 != numero2 && numero1 != numero3)
                {
                    Console.WriteLine("Es un triangulo ESCALENO");
                }
                Console.ReadKey();

                Console.WriteLine("Desea Continuar? Y/N");
                string respuesta = Console.ReadLine();

                if (respuesta == "N")
                    break;

            }


        }
    }
}
