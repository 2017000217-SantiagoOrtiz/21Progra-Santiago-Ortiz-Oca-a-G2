internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escoja una opcion de las siguientes");
        Console.WriteLine("1 Hamburguesa");
        Console.WriteLine("2 Pizza");
        Console.WriteLine("3 Pollo frito");
        Console.WriteLine("4 Ensalada");
        int op = Convert.ToInt32(Console.ReadLine());
        switch (op) { 
        case 1: 
            Console.WriteLine("Hamburguesa");
            break;
         case 2:
                Console.WriteLine("Pizza");
                break;
         case 3:
                Console.WriteLine("Pollo Frito");
                break;
            case 4:
                Console.WriteLine("Ensalada");
                break;
            default:
                Console.WriteLine("No existe esa opcion");
                break;
        }
    }
}