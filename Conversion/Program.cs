using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2, resultado;

            //Preguntamos al usuario el numero
            Console.WriteLine("Dame un numero para sumar: ");
            //Se asigna la variable tipo string
            cadena = Console.ReadLine();
            num2 = Int32.Parse("cadena");        //Tambien se puede hacer de esta manera
                                               //num2 = Convert.ToInt32(cadena);  //Tambien se puede hacer de esta manera
                                               //Realizar suma
            resultado = num1 + num2;
            //Mostrar el resultado
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
