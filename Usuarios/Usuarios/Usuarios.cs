namespace Usuarios
{
    public class Usuarios
    {
        private string nombre;
        private int edad;
        private string genero;

        public Usuarios(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }
        
        // Metodos necesarios 
        
        public string getNombre()
        {
            return nombre;
        }
        
        public string getGenero()
        {
            return genero;
        }

        public int getEdad()
        {
            return edad;
        }
    }
}