// Utilizacion de librerias 
using System;

// Agrupacion de archivos
namespace Ejemplo1
{
    // Clase
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Best practices (Carpeta -> Github)
            // 1. Mayoria del codigo tiene que estar en ingles (exceptuando
            //    comentarios e impresiones) 
            // 2. Comentar el codigo (Documentar)
            // 3. Apertura de llaves
            // 4. Inicializar las variables

            // Variables Explicitas (Se les declara el tipo)
            int num = 20; 
            char letter = 'a'; 
            string str = "Hola a todos";
            float f = 12.35f; 
            double d = 12.75d; 

            //V ariables Implicitas (Preferida)
            // Objetos con herencia, Variables de interfaz
            var aInteger = 1; 
            var aLetter = 'r';
            var aString = "Implicit var";
            var aFloat = 3.14f; 
            var aDouble = 3.14; 

            /* 
                META 1 (VSCode)
                META 2 (Rider)
                    Roslyn Fixes
                META 3 (Cualquiera)
            */
            
            // Cadena interpolada (Combinar strings con variables)
            for(var j = 0; j < 20; j++)
                Console.WriteLine($"El numero es {j}");
                // Es igual a: 
                // for(var j = 0; j < 20; j++)
                //      Console.WriteLine("El numero es " + j);
            
            var word = "Fernando";
            
            word = word.ToLower(); 

            for(int i = 0; i < word.Length; i++)
            {
                switch(word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i': 
                    case 'o':
                    case 'u': 
                        Console.WriteLine($"El caracter {word[i]} es vocal");
                        break; 
                    default:
                        Console.WriteLine($"El caracter {word[i]} no es vocal");
                        break; 
            }
        }

        // Parseo, Parsing -> Convertir un string a un tipo X
        int edad = 0; 

        Console.WriteLine("Cual es tu edad?");
        edad = Int32.Parse(Console.ReadLine());

        char a = Char.Parse(Console.ReadLine());
        char e = Console.ReadLine()[0];

        double dd = Double.Parse(Console.ReadLine());

        Console.ReadKey(); 
        }

        static int AddNumbers(int a, int b)
        {
            return a + b; 
        }

        static double SubstractNumbers(int a, int b)
        {
            return a - b; 
        }

        static string ConvertToUpperCase(string word)
        {
            return word.ToUpper(); 
        }
    }
}

