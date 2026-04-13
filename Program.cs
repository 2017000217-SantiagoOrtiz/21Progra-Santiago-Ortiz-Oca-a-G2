internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Clasificacion de letras por rango");
        Console.WriteLine("Dame una letra:");
        char letra = Convert.ToChar(Console.ReadLine().ToUpper());
        switch (letra)
        {
            case 'A'  :
                Console.WriteLine("Excelente");
                break;
            case 'B':
                Console.WriteLine("Bueno");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            case 'D':
                Console.WriteLine("Deficiente");
                break;
            case 'F':
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Letra no valida");
                break;
        }
    }
}
