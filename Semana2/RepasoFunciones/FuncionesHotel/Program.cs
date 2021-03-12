using System;

namespace FuncionesHotel
{
    class Program
    {
        public static int max = 0;
        public static int available = 0; 
        public static int dispatched = 0; 
        static void Main(string[] args)
        {
            Console.Write("Máximo de habitaciones: ");
            max = Int32.Parse(Console.ReadLine());
            available = max; 
            
            bool menuFlag = true;  
            while(menuFlag)
            {
                switch(showMenu())
                {
                    case 1: book(); break; 
                    case 2: dispatch(); break; 
                    case 3: statusInf(); break; 
                    case 4: profits(); break; 
                    case 5: menuFlag = false; break; 
                    default: 
                        Console.WriteLine("Intentelo de nuevo"); 
                        Console.WriteLine(); 
                        break; 
                }
            }
        }
        public static int showMenu()
        {
            Console.WriteLine("Bienvenido!"); 
            Console.WriteLine("1) Reservar habitaciones.");
            Console.WriteLine("2) Despachar habitaciones.");
            Console.WriteLine("3) Disponibilidad de habitaciones");
            Console.WriteLine("4) Calcular ganancias."); 
            Console.WriteLine("5) Salir");
            Console.Write("Ingrese una opcion: "); 
            int opcion = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine(); 
            return opcion; 
        }

        public static void book()
        {
            Console.Write("Cantidad de habitaciones a reservar: ");
            int rooms = Int32.Parse(Console.ReadLine()); 
            if(rooms > 0 && rooms <= max)
            {
                available -= rooms; 
                Console.WriteLine("Habitaciones reservadas con éxito!");
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Error!");
                Console.WriteLine(); 
            }
        }

        public static void dispatch()
        {
            Console.Write("Cantidad de habitaciones a despachar: ");
            int rooms = Int32.Parse(Console.ReadLine());
            int unavailable = max - available; 
            if(rooms > 0 && rooms <= unavailable)
            {
                available += rooms; 
                dispatched += rooms; 
                Console.WriteLine("Habitaciones despachadas con éxito!");
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Error!");
                Console.WriteLine(); 
            }
        }

        public static void statusInf()
        {
            Console.WriteLine($"Habitaciones disponibles: {available}");
            int unavailable = max - available; 
            Console.WriteLine($"Habitaciones ocupadas: {unavailable}");
            Console.WriteLine(); 
        }

        public static void profits()
        {
            int profit = dispatched*15; 
            Console.WriteLine($"Total de habitaciones depachadas: {dispatched}");
            Console.WriteLine($"Ganancias: ${profit}");
            Console.WriteLine(); 
        }
    }
}
