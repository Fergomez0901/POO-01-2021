using System;
using System.Collections.Generic; 

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*  var boat = new Transport("Bote", null);
            var car = new Transport("Carrito", 2.5);  

            boat.UseTransport();
            car.UseTransport();
        */
            var people = new List<string>();

            people.Add("Walter");
            people.Add("Fernando");
            people.Add("Alicia");
            people.Add("Rodrigo");
            people.Add("Mariana");

            Console.WriteLine("For normal: ");
            for(var i = 0; i < people.Count; i++)
                Console.WriteLine(people[i]); 

            Console.WriteLine(); 

            Console.WriteLine("foreach");
            foreach(var element in people)
                Console.WriteLine(element);

            //Lambda -> Arrow Functions 

            var numList = new List<int>(); 

            for(var i = 0; i< 8 ; i++)
                numList.Add(i);
            
            //Lambda
            numList.RemoveAll(num => 
            {
                return num % 2 == 0;
            });

            numList.ForEach(num =>
            {
                Console.WriteLine(num * 2); 
            });

            people.ForEach(person =>
            {
                Console.WriteLine($"{person} te ha saludado");
            });

            people.RemoveAll(person =>
            {
                return person.StartsWith('W'); 
            }); 
        }
    }
}

