
using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {   
        //DEclaracion de variables
            // viables tipo texto con captura desde consola

            string? primerNombre ="Steven";
            string? segundoNombre = "Schafick";
            string? primerApellido = "Molina";
            string? segundoApellido = "Ventura";

            
            // Declaracion de variables enteras asignando valores
            int edadMia =23;
            int edadGfa =45;
            int edadHermano =25;

            // variables float asignado valor desde consola

            double cuotaUniversidad = 115.00;
            double comidaSem = 54.75;
            double gasolinaSem = 43.50;

            // varibales boolean asignando valores
            bool estadoMateria = true;
            bool bacado = false;

        
            // Impresion de datos en consola
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos de tipo texto----------------*");
            Console.WriteLine("\n Mi primer nombre es >>" + primerNombre);
            Console.WriteLine("\n Mi segundo nombre es >>" + segundoNombre);
            Console.WriteLine("\n Mi primer apellido es  >>" + primerApellido);
            Console.WriteLine("\n Mi segundo apellido es   >>" + segundoApellido);
            Console.WriteLine("\n***************************************************************"); 


            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos enteros----------------*");
            Console.WriteLine("\n Mi edad es >>" + edadMia+ " años");
            Console.WriteLine("\n Las edad de mi mamá es   >>" + edadGfa+" años");
            Console.WriteLine("\n La edad de mi hermano mayor es  >>" + edadHermano+ " años");
            Console.WriteLine("\n***************************************************************"); 


            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos de tipo float----------------*");
            Console.WriteLine("\n La Cuota de mi universidad es >>" + cuotaUniversidad);
            Console.WriteLine("\n El gasto en mi comida semana es   >>" + comidaSem);
            Console.WriteLine("\n El gasto en gasolina semanal es   >>" + gasolinaSem);
            Console.WriteLine("\n***************************************************************"); 


            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("\n----------------impresion de datos de tipo boolean----------------*");
            Console.WriteLine("\n Soy un estudiante activo en la materia>>" + estadoMateria);
            Console.WriteLine("\n Soy un estudiante becado  >>" + bacado);
            Console.WriteLine("\n***************************************************************"); 

            Console.ReadKey();


        }
    }
}