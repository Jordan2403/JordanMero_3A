using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que lea números enteros
//indefinidamente hasta que llegue el número 0
namespace JordanMero_3A
{
    internal class NumrosIndifinidos
    {
        public void main (string[] args) 
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese un nuemro");
                numero = Convert.ToInt32(Console.ReadLine());

            } while (numero != 0);
            Console.ReadKey();
        }
    }
}
