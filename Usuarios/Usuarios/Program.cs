using System;

namespace Usuarios
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Obteniendo datos de un usuario atravez de una clase
            
            // Instanciamos Objetos

            Usuarios usuario1 = new Usuarios("Daniel", 22, "m");
            Usuarios usuario2 = new Usuarios("Maria", 25, "f");
            
            // Mostramos datos de los usuarios
            Console.WriteLine("Nombre: " + usuario1.getNombre());
            Console.WriteLine("Genero: " + usuario1.getGenero());
            Console.WriteLine("Edad: " + usuario1.getEdad());
            
            Console.WriteLine();
            
            Console.WriteLine("Nombre: " + usuario2.getNombre());
            Console.WriteLine("Genero: " + usuario2.getGenero());
            Console.WriteLine("Edad: " + usuario2.getEdad());
        }
    }
}