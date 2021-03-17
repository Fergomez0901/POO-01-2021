using System; 

namespace Laboratorio2
{
    class Person
    {
        //Atributos
        private string firstName, lastName, nationality, profession; 
        private char gender; 
        private int age; 

        //Metodos
        //Constructor
        public Person(string firstName, string lastName, string nationality, string profession, char gender, int age)
        {
            this.firstName = firstName; 
            this.lastName = lastName; 
            this.profession = profession; 
            this.nationality = nationality; 
            this.age = age; 
            this.gender = gender; 
        }

        public void Greet()
        {
            Console.WriteLine($"{firstName} te está saludando!"); 
        }

        public void Walk(string from, string to)
        {
            Console.WriteLine($"{firstName} camina desde {from} hasta {to}");
        }

        public void Talk(string message)
        {
            Console.WriteLine($"{firstName} dice: \"{message}\""); 
        }
        public bool StartsWith(char letter)
        {
            if(firstName[0] == letter)
                return true; 
            else
                return false; 
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine($"Nombre completo: {firstName} {lastName}");
            Console.WriteLine($"Edad: {age}");
            Console.WriteLine($"Nacionalidad: {nationality}");
        }
    }
}
