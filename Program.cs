using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.calificación_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double calificacion1, calificacion2, calificacion3, calificacion4; //definimos los tipos de valores.
            double promedio;

            Console.WriteLine("Introduce la primera calificacion: ");
            calificacion1 = double.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente

            Console.WriteLine("Introduce la segunda calificacion: ");
            calificacion2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la tercera calificacion: ");
            calificacion3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cuarta calificacion: ");
            calificacion4 = double.Parse(Console.ReadLine());

            promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4) / 4; //el promedio es la suma de las 4 calificaciones divido entre 4.

            if (promedio >= 90)                                     //La instrucción if controla la bifurcación condicional. 
                Console.WriteLine("el promedio es A = " + promedio);
            else if (promedio >= 80)
                Console.WriteLine("el promedio es B = " + promedio); //Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida
            else if (promedio >= 70)
                Console.WriteLine("el promedio es  C = " + promedio);
            else if (promedio >= 60)
                Console.WriteLine("el promedio es  D = " + promedio);
            else
                Console.WriteLine("el promedio es E = " + promedio);

            Console.ReadLine(); // imprimimos el resultado
        }
    }
}
