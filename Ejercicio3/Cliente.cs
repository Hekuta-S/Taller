using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Cliente
    {
        int numeroCuenta;
        int saldoApertura;
        string nombre;

        public Cliente(string nombre, int numeroCuenta, int saldoApertura)
        {
            this.nombre = nombre;
            this.numeroCuenta = numeroCuenta;
            this.saldoApertura = saldoApertura;
        }

        public Cliente()
        {
           
        }
        
        public void Consignar(int valorConsignacion)
        {
            this.saldoApertura = this.saldoApertura + valorConsignacion;
        }

        public void Retirar(int valorRetiro)
        {
            this.saldoApertura = this.saldoApertura - valorRetiro;
        }

        public string MostrarSaldo()
        {
            return ("Su saldo es: " + this.saldoApertura);
        }



    }
}
