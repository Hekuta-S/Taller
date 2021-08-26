using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio;

            Console.WriteLine("ingrese la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese la tercera nota: ");
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 ) / 3;

            if (promedio < 3)
            {
                Console.WriteLine("el estudiante perdio la materia.");

            } 
            else
            {
                Console.WriteLine("el estudiante gano la materia.");
            }

            Console.WriteLine("con un promedio de: " + promedio); 

        }
    }
}
