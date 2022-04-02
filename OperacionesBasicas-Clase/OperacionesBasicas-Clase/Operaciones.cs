using System;

namespace OperacionesBasicas_Clase
{
    public class Operaciones
    {
        // Atributos
        private double numnA, numB;

        // Constructor
        public Operaciones(double numnA, double numB)
        {
            this.numnA = numnA;
            this.numB = numB;
        }
    
        // Metodo de suma
        public double suma()
        {
            return numnA + numB; // Retornamos la suma
        }
        
        // Metodo de resta
        public double resta()
        {
            return numnA - numB; // Retornamos la resta
        }
        
        // / Metodo de multipliacion
        public double multiplicacion()
        {
            return numnA * numB; // Retornamos la multiplicacion
        }
        
        // Metodo de division
        public double division()
        {
            return numnA / numB; // Retornamos la division
        }
    }
}