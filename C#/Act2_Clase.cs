internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite dos numeros:");
        float num1= float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite un Caracter");
        Console.WriteLine("1 Sumar");
        Console.WriteLine("2 Restar");
        Console.WriteLine("3 Multiplicar");
        Console.WriteLine("4 Division");
        int c = Convert.ToInt32 (Console.ReadLine());
        switch (c) { 
            case 1:
            Console.WriteLine("La suma es, "+(num1+num2));
            break;
            case 2:
                Console.WriteLine("La suma es, " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("La suma es, " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("La suma es, " + (num1 / num2));
                break;
            default:
                Console.WriteLine("No existe ese caracter");
                break;
        }
    }
}