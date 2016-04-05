using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase04
{
    class Dato
    {
        public int numero;
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Factura fac1 = new Factura(10f, 1);
            Factura fac2 = new Factura(2, 10f);
            //Factura fac3 = new Factura(2, 4f, DateTime.Now);

            float resul = fac1 + fac2; //ERROR no se pueden sumar dos facturas
            //float resul = fac1.importe + fac2.importe;

            if (fac1 == fac2)//ERROR no compara la igualdad de las dos facturas
            {
                Console.Write("Tienen el mismo importe");
            }
            else
            {
                Console.Write("No son iguales");
            }

            Cheque chequeUno = new Cheque(2f);
            float resultadoCheque = fac1 - chequeUno;

            chequeUno = chequeUno + fac1;

            /*Dato A = new Dato();
            Dato B = new Dato();

            A.numero = 22;
            B.numero = 30;
            B.numero = 5;
            A = B;//
            A.numero = 10;*/
            Console.ReadKey();
        }
    }
}
