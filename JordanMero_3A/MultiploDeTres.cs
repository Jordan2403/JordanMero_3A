using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que escriba todos los múltiplos de 3 del número 1 al 3000 
namespace JordanMero_3A
{
    internal class MultiploDeTres
    {
        public void main (String[] args) 
        {
            int numero = 3000;
            int i;
            

            for (i=1; i <= numero; i = i + 3) 
            {
                Console.WriteLine("||"+ i);
            }
        }
    }
}
