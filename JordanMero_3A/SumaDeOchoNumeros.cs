using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Escribir un programa que lea exactamente 8 números y luego escriba la suma de todos ellos
namespace JordanMero_3A
{
    internal class SumaDeOchoNumeros
    {
        public void main (string[] args) 
        {
            int numeros;
            int suma = 0;
            int i;

            for (i=0; i < 8; i++) 
            {
                Console.WriteLine("Ingrese 8 numeros");
                numeros = Convert.ToInt32 (Console.ReadLine());
                suma = suma + numeros;
            }
            Console.WriteLine("La sumas total de los 8 numeros es: " + suma);
        }
    }
}
