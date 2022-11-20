using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Modificar el programa anterior para que en lugar de leer 8 números, se puedan leer tantos números
// como se quiera hasta que llegue un cero. El resultado es la suma de todos los números leídos.
namespace JordanMero_3A
{
    internal class SumaDeXNumeros
    {
        public void main(string[] args)
        {
            int numeros;
            int suma = 0;
            int i;
            int valor;

            Console.WriteLine("Ingrese la cantidad de numeros a sumar");
            numeros = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Ingrese valor");
                valor = Convert.ToInt32(Console.ReadLine());
                suma = suma + valor;
            
            }
            Console.WriteLine("La suma total es: " + suma);
            Console.ReadKey();
        }
    }
}
