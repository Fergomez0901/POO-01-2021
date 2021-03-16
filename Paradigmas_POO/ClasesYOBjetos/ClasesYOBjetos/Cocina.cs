using System; 
namespace ClasesYOBjetos
{
    public class Cocina
    {
        //Atributos
        private int quemadores; 
        private string color; 
        private string marca; 
        private string combustible;
        private bool tieneHorno; 
        
        //Constructores
        public Cocina(int pQue, string pCol, string pMar, string pCom, bool pTH) 
        {
                 quemadores = pQue; 
                 color = pCol; 
                 marca = pMar; 
                 combustible = pCom; 
                 tieneHorno = pTH; 
        }
        
        //Métodos
        public void encender()
        { 
            Console.WriteLine("Encendiendo...");
        }
        public void apagar()
        {
            Console.WriteLine("Apagando...");
        }
        public void hornear()
        {
            if(tieneHorno)
                Console.WriteLine("Horneando...");
            else
                Console.WriteLine("Error..."); 
        }   
    }
}