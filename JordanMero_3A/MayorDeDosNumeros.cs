using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que lea dos números y que escriba el mayor de los dos.
namespace JordanMero_3A
{
    internal class MayorDeDosNumeros
    {
        public void main (string[] args) 
        {
            int num1;
            int num2;
            int mayor;

            Console.WriteLine("Ingrese primer valor");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor");
            num2 = Convert.ToInt32(Console.ReadLine()); ;

            if (num1 > num2) 
            {
                mayor = num1;
            }
            else 
            {
                mayor = num2;
            }

            Console.WriteLine("Valor de mayor: " + mayor);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            
        }
 
    }
}
