using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleCalcApp.Models
{
    public class Operacion
    {
        public static Operacion op = new Operacion();
        
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
                    
                case "Resta":
                    return Restar(poperacion);
                    
                case "Division":
                    return Dividir(poperacion);
                    
                case "Multiplicacion":
                    return Multiplicar(poperacion);
                    
            }
            return null;
        }

        private static Operacion Multiplicar(Operacion poperacion)
        {
            return op = new Operacion(poperacion.tipOperacion, poperacion.valor1, poperacion.valor2, poperacion.valor1 * poperacion.valor2);
        }

        private static Operacion Dividir(Operacion poperacion)
        {
            return op = new Operacion(poperacion.tipOperacion, poperacion.valor1, poperacion.valor2, poperacion.valor1 / poperacion.valor2);
        }

        private static Operacion Restar(Operacion poperacion)
        {
            return op = new Operacion(poperacion.tipOperacion, poperacion.valor1, poperacion.valor2, poperacion.valor1 - poperacion.valor2);
        }

        private static Operacion Sumar(Operacion poperacion)
        {
            return  op = new Operacion(poperacion.tipOperacion,poperacion.valor1, poperacion.valor2, poperacion.valor1+poperacion.valor2);
        }
    }
}