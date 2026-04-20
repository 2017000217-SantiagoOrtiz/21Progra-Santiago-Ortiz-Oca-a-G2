internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digame un numero");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione una medida");
        Console.WriteLine("a - Metros");
        Console.WriteLine("b - Pies");
        Console.WriteLine("c - Centimetros");
        Console.WriteLine("d - Pulgadas");
        string op = Console.ReadLine();

        switch (op) {
            case "a" or "A":
                Console.WriteLine("La convercion es, "+n+" Metros");
                break;
            case "b" or "B":
                Console.WriteLine("La convercion es, " + n + " Pies");
                break;
            case "c" or "C":
                Console.WriteLine("La convercion es, " + n + " Metros");
                break;
            case "d" or "D":
                Console.WriteLine("La convercion es, " + n + " Metros");
                break;
            default:
                Console.WriteLine("No existe esta medida");
                break;
        }

    }
}