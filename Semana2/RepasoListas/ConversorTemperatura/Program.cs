using System;
using System.Collections.Generic; 
using System.Linq; 

namespace ConversorTemperatura
{
    class Program
    {
        public static List<double> listT = new List<double>(); 
        static void Main(string[] args)
        {
            bool toContinue = true; 
            while(toContinue)
            {
                switch(showMenu())
                {
                    case 1: addT(); break;
                    case 2: removeT(); break;
                    case 3: displayMaxT(); break;
                    case 4: displayAllTC(); break; 
                    case 5: displayAllTF(); break;
                    case 6: displayAllTK(); break;
                    case 7: toContinue = false; break; 
                }
            }
        }

        public static int showMenu()
        {
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("1) Agregar temperatura (Celsius)");
            Console.WriteLine("2) Quitar temperatura"); 
            Console.WriteLine("3) Mostrar temperatura máxima (Celsius)"); 
            Console.WriteLine("4) Mostrar temperaturas en Celsius.");
            Console.WriteLine("5) Mostrar temperaturas en Farenheit.");
            Console.WriteLine("6) Mostrar temperaturas en Kelvin.");
            Console.WriteLine("7) Salir.");
            Console.Write("Ingrese una opcion: ");
            int opcion = Int32.Parse(Console.ReadLine());
            return opcion; 
        }

        public static void addT()
        {
            Console.Write("Ingrese una temperatura en grados Celsius: ");
            double temp = Double.Parse(Console.ReadLine());
            listT.Add(temp);  
        }

        public static void removeT()
        {
            Console.Write("Ingrese el indice de la temperatura a eliminar: ");
            int index = Int32.Parse(Console.ReadLine());
            listT.RemoveAt(index); 
        }

        public static void displayMaxT()
        {
            Console.WriteLine($"Temperatura máxima: {listT.Max()}");
        }

        public static void displayAllTC()
        {
            Console.WriteLine("Celsius: ");
            foreach(double temp in listT)
                Console.Write($"{temp} - "); 
        }

        public static void displayAllTF()
        {
            Console.WriteLine("Farenheit: ");
            foreach(double temp in listT)
                Console.Write($"{(temp*9/5)+32} - ");
        }

        public static void displayAllTK()
        {
            Console.WriteLine("Farenheit: ");
            foreach(double temp in listT)
                Console.Write($"{temp+273.15} - ");
        }

    }
}
