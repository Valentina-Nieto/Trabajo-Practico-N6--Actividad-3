using System;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un programa donde se definan variables de tipo lógico, entero, cadena texto y
            decimal. Almacene un dato correspondiente para cada tipo y muestre el contenido de cada
            variable por pantalla.*/
            
            int variableEntera = 18;
            string variableCadena = "Hola";
            bool variableLogica = true;
            float variableDecimal = 12.25f;

            Console.Clear();

            Console.WriteLine("La primera variable es entera '{0}', la segunda variable es una cadena '{1}', la tercera variable es una lógica '{2}' y la última variable es decimal '{3}'", variableEntera, variableCadena, variableLogica, variableDecimal);
            
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();

        }
    }
}
