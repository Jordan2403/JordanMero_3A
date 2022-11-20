using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Programa que lea una serie de números (leer hasta que llegue el cero por ejemplo) y que calcule su media aritmética
namespace JordanMero_3A
{
    internal class MediaAritmetica
    {
        public void main (string [] args) 
        {
            int numero;
            int i;
            int suma =0;
            int valor;
            int media=0;

            Console.WriteLine("Ingrese la cantidad de numeros a calcular");
            numero = int.Parse(Console.ReadLine());

            for (i = 1; i <= numero; i++)
            {
                Console.WriteLine("Ingrese numeros a calcular "+ i);
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
                media = suma / numero;
            
            }

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("la media aritmetica es :" + media);
            Console.ReadKey();
        
        }
    }
}
