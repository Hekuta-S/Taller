using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, respuesta;
            int numeroCuenta, saldoApertura, monto=0;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su número de cuenta: ");
            numeroCuenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su saldo de apertura: ");
            saldoApertura = int.Parse(Console.ReadLine());
            Console.WriteLine("Quiere Consignar(C) o Retirar(R) su dinero? ");
            respuesta = Console.ReadLine();

            Cliente cliente = new Cliente(nombre, numeroCuenta, saldoApertura);
            
            if (respuesta == "C")
            {
                Console.WriteLine("Que valor va a consignar? ");
                monto = int.Parse(Console.ReadLine());
                cliente.Consignar(monto);
            }
            else if (respuesta == "R")
            {
                Console.WriteLine("Que valor va a retirar? ");
                monto = int.Parse(Console.ReadLine());
                cliente.Retirar(monto);
            }
            
            Console.WriteLine(cliente.MostrarSaldo());
        }
       
    }
}
