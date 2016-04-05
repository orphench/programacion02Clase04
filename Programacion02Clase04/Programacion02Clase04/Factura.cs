using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase04
{
    class Factura
    {
        //SOBRECARGA DE METODOS
        
        public DateTime fecha;
        public float importe;
        public int numero;

        public Factura()
        {
            this.fecha = DateTime.Now;
        }

        public Factura(int numero, float importe):this()
        {   
            //:this() invoca al constructor que inicializa la fecha para no repetir codigo
            this.numero = numero;
            this.importe = importe;
            //this.fecha = DateTime.Now;
        }

        //public Factura(int A, float B)ERROR son los mismos parametros que el construsctor de arriba
        public Factura(float importe, int numero):this(numero, importe)
        {
            //:this(numero, importe) invoca al constructor que recibe int y float por parametro
            //this.fecha = DateTime.Now;
            /*this.importe = importe;
            this.numero = numero;*/
            
        }

        public Factura(int numero, float importe, DateTime ahora):this(numero, importe)
        {
            
        }

        public Factura(float importe, int numero, DateTime ahora):this(importe, numero)
        {
            
        }

        public Factura(DateTime ahora, float importe, int numero):this(importe, numero)
        {
            
        }

        public Factura(float importe):this()
        {

        }

        public Factura(int numero):this()
        {
 
        }

        //SOBRECARGA DE OPERADORES
        public static float operator +(Factura facturaUno, Factura facturaDos)
        {
           float resultado = facturaUno.importe + facturaDos.importe;

           return resultado;
        }

        public static bool operator ==(Factura facturaUno, Factura facturaDos)
        {
            bool comparacion = facturaUno.importe == facturaDos.importe;

            return comparacion;
        }

        public static bool operator !=(Factura facturaUno, Factura facturaDos)
        {
            return !(facturaUno == facturaDos);
        }

        
    }
}
