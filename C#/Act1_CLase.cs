internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dijite un numero del 1 al 7");
        Console.WriteLine("1 - Lunes");
        Console.WriteLine("2 - Martes");
        Console.WriteLine("3 - Miercoles");
        Console.WriteLine("4 - Jueves");
        Console.WriteLine("5 - Viernes");
        Console.WriteLine("6 - Sabado");
        Console.WriteLine("7 - Domingo");
        int dia=Convert.ToInt32(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Numero no valido");
                break;
        }
    }
}