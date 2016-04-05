using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase04
{
    class Cheque
    {
        public float importe;

        public Cheque(float importe)
        {
            this.importe = importe;
        }

        public static float operator -(Factura facturaUno, Cheque chequeUno)
        {
            float resultado = facturaUno.importe - chequeUno.importe;
            return resultado;
        }

        public static Cheque operator +(Cheque chequeUno, Factura facturaUno)
        {
            return new Cheque(chequeUno.importe + facturaUno.importe);
            

            
        }
    }
}
