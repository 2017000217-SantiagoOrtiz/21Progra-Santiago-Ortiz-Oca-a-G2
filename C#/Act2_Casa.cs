internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba un caracter:");
        string c = Console.ReadLine();

        switch (c) {
            case "A" or "a":
            case "E" or "e":
            case "I" or "i":
            case "O" or "o":
            case "U" or "u":
                Console.WriteLine("Es una vocal.");
                break;
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                Console.WriteLine("Es un digito.");
                break;
            default:
                Console.WriteLine("No es ni vocal ni dígito.");
                break;
        }
    }
}