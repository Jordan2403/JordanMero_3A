using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear un programa que lea un número e indique si es par o no 
namespace JordanMero_3A
{
    internal class Numero_Par_Impar
    {
        public void main(string[] args)
        {
            int Numero;

            Console.Write("Ingrese un numero");
            Numero = Convert.ToInt32(Console.ReadLine());
            long sobrante = Numero % 2;

            if (sobrante == 0)
            {
                Console.WriteLine("Elnumero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

        }
    }
}
