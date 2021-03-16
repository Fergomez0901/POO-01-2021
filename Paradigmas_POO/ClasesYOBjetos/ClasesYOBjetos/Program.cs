namespace ClasesYOBjetos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cocina cocina01 = new Cocina(4, "azul", "Samsung", "electrica", true);
            cocina01.encender();
            cocina01.hornear();
            cocina01.apagar(); 
        }
    }
}