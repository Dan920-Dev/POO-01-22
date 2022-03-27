using System;

namespace Palindrome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // Llamando la funcion 
            Console.WriteLine("¿La frase ingresada es Palindrome? " + funPalindrome());
            
        }
        // Funcion Booleana 
        static bool funPalindrome()
        {
            // Solicitando frase al usuario
            string sentenece = "";
            Console.Write("Digite una frase, el programa determinara si es palindrome o no! ");
            sentenece = Console.ReadLine();
            
            //  Tolower() Devuelve una copia de esta cadena convertida a minúsculas.
            sentenece = sentenece.ToLower();
            
            // Replace() Devuelve una nueva cadena en la que todas las apariciones de un carácter Unicode especificado
            // en esta instancia se reemplazan con otro carácter Unicode especificado.
            sentenece = sentenece.Replace("\\s", "");
            
            // Length - para saber la longitud de la frase y poder recorrerla
            int size = sentenece.Length;

            // Verificacion con for
            for (int i = 0; i < size; i++)
            {
                if (sentenece[i] == sentenece[size - 1 - i]) return true;
            }

            return false;
        }
    }
}