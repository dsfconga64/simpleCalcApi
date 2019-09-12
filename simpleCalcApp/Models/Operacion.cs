using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleCalcApp.Models
{
    public class Operacion
    {
        public static Operacion op = new Operacion();
        //Comment cambio github
        public String tipOperacion { get; set; }
        public double valor1{ get; set; }
        public double valor2 { get; set; }
        public double  resultado{ get; set; }

        public Operacion()
        {
        }
        public Operacion(String ptipo, double pvalor1, double pvalor2, double presultado)
        {
            this.tipOperacion = ptipo;
            this.valor1 = pvalor1;
            this.valor2 = pvalor2;
            this.resultado = presultado;
        }
        
        public static  Operacion procesar (Operacion poperacion)
        {
            switch (poperacion.tipOperacion)
            {
                case "Suma":
                    return Sumar(poperacion);
                    //break;
                case "Resta":
                    return Restar(poperacion);
                    //break;
                case "Division":
                    return Dividir(poperacion);
                    //break;
                case "Multiplicacion":
                    return Multiplicar(poperacion);
                    //break;
            }
            return null;
        }

        private static Operacion Multiplicar(Operacion poperacion)
        {
            throw new NotImplementedException();
        }

        private static Operacion Dividir(Operacion poperacion)
        {
            throw new NotImplementedException();
        }

        private static Operacion Restar(Operacion poperacion)
        {
            throw new NotImplementedException();
        }

        private static Operacion Sumar(Operacion poperacion)
        {
            return  op = new Operacion(poperacion.tipOperacion,poperacion.valor1, poperacion.valor2, poperacion.valor1+poperacion.valor2);
 
        }
    }
}