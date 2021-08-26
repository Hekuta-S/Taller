using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string sexo;
            double edad, pulsaciones = 0;
            Console.WriteLine("su sexo es femenino(F) o masculino(M)?");
            sexo = Console.ReadLine();
            Console.WriteLine("Cual es su edad? ");
            edad = double.Parse(Console.ReadLine()); 

            if (sexo == "F")
            {
                pulsaciones = (220 - edad) / 10;

            }
            else if (sexo == "M") {
                pulsaciones = (210 - edad) / 10;
            }
              
            Console.WriteLine("El número de sus pulsaciones es: " + pulsaciones); 
        }
    }
}
