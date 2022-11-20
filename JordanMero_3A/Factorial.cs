using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Programa que lea un número entero por teclado y que calcule su factorial.
namespace JordanMero_3A
{
    internal class Factorial
    {
        public void main (string [] args) 
        {
            int numero;
            int factorial;
            int con;

            Console.WriteLine("Ingrese el valor de N!");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0 ) 
            {
                Console.WriteLine("El factorial de (0) es 1" + numero);
            }
            else 
            {
                factorial = numero;
                for (con = numero; con>= 1; con++) 
                {
                    factorial = factorial * (con - 1);

                }

                Console.WriteLine("El factorial de:" + numero + " es:" + factorial);
            }
            Console.ReadKey();
        }
    }
}
