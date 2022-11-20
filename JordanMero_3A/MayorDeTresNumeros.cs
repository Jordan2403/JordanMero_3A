using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Leer tres números y escribir el mayor de los tres
namespace JordanMero_3A
{
    internal class MayorDeTresNumeros
    {
        public void main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int Mayor = 0;

            Console.WriteLine("Ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Ingrese el tercer numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Mayor = num1;
            }
            if ((num2 > num1) && (num2 > num3))
            {
                Mayor = num2;
            }
            if ((num3 > num1) && (num3 > num2))
            {
                Mayor = num3;
            }

            Console.WriteLine("Valor de mayor: " + Mayor);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");


        }
    }
}
