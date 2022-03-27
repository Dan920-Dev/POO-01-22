using System;

namespace CalculadoraBasica
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            //Escribe tu programa sobre una calculadora que realice las 4 operaciones basicas
            /*
             * Requerimientos:
             *
             * Realizar las operaciones según la opción que seleccione el usuario, mediante un menú repetitivo
             * Programar una opcion para salir del menú.
             * 
             */
            
            // Declaracion de Variables
            int num1, num2, opc = 0; // opc - para opcion del menu
            double result = 0;
            bool continuar = true; // Para validar el do-while
            
            
            // Do-while para repetir el menu
            do
            {
                Console.WriteLine(" *** Menu *** ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Digite la opcion que desea");
                opc = Convert.ToInt32(Console.ReadLine());
                
                // Menu utilizando switch
                switch (opc)
                {
                    // Para la suma
                    case 1:
                        Console.WriteLine("Digite el primer dato");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo  dato");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        opc = num1 + num2;
                        Console.WriteLine("El resultado de sumar los datos es: " + opc);
                        break;
                    
                    // Para la resta
                    case 2:
                        Console.WriteLine("Digite el primer dato");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo  dato");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        opc = num1 - num2;
                        Console.WriteLine("El resultado de restar los datos es: " + opc);
                        break;
                    
                    // Para la multiplicacion
                    case 3:
                        Console.WriteLine("Digite el primer dato");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo  dato");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        opc = num1 * num2;
                        Console.WriteLine("El resultado de Multiplicar los datos es: " + opc);
                        break;
                    
                    // Para la division
                    case 4:
                        Console.WriteLine("Digite el primer dato");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo  dato");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        opc = num1 / num2;
                        Console.WriteLine("El resultado de sumar los datos es: " + opc);
                        break;
                    
                    // Para salir del menu
                    case 5:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Esta opcion no se encuentra dentro de menu");
                        break;
                }
            } while (continuar); // Mientras sea true se estara repitiendo el menu
        }
    }
}