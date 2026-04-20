internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Diga donde se quiere sentar");
        Console.WriteLine("1 Palco - Q300.00");
        Console.WriteLine("2 Tribuna - Q125.00");
        Console.WriteLine("3 Prefernecia - Q75.00");
        Console.WriteLine("4 Generales - Q50.00");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Diga la Cantidad de entradas");
        int c = int.Parse(Console.ReadLine());

        switch (d)
        {
            case 1:
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, del Palco, el total seria, " + (c * 300.00) + "Q");
                break;
            case 2:
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, del Tribuna, el total seria, " + (c * 100.00) + "Q" + " a " + (c * 125.00) + "Q");
                break;
            case 3:
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, de Preferencia, el total seria, " + (c * 50.00) + "Q" + " a " + (c * 75.00) + "Q");
                break;
            case 4:
                Console.WriteLine("Ok, necesita " + c + " boletos, en el sector, General, el total seria, " + (c * 30.00) + "Q" + " a " + (c * 50.00) + "Q");
                break;
            default:
                Console.WriteLine("Valor no valido");
                break;
        }
    }
}