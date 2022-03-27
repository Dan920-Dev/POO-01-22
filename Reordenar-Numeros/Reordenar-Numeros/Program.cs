using System;

namespace Reordenar_Numeros
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Reordenador de numeros 
            // ejemplo:  si el usuario ingresa n = 3, se debe mostrar en pantalla
            // resultado: 1 2 3 2 1
            
            
            // Solicitando el valor de n al usuario
            int n;
            Console.Write("Digite el valor de n: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            // Evaluando que el numero sea valido
            if(n > 0){
                funRecursive(n, 1, true);
            }else{
                Console.WriteLine("Numero ingresado es invalido!");
            }
        }
        
        
        // Funcion recursiva
        static void funRecursive(int n, int baseNumber, bool valid){
            
            if(valid) {
                if(baseNumber < n){
                    Console.Write(baseNumber + " ");
                    baseNumber++;
                    funRecursive(n, baseNumber, valid);
                }else{

                    if(baseNumber == n){
                        valid = false;
                        Console.Write(baseNumber + " ");
                        baseNumber--;
                        funRecursive(n, baseNumber, valid);
                    }
                }
            }else {

                if(baseNumber > 1){
                    Console.Write(baseNumber + " ");
                    baseNumber--;
                    funRecursive(n, baseNumber, valid);
                }else{

                    Console.Write(baseNumber);
                }
            }
        }
    }
}