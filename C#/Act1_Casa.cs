internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escribe un angulo");
        double ag=double.Parse(Console.ReadLine());
        double Res = 0;

        Console.WriteLine("Escriba una funcion trigonometrica");
        Console.WriteLine("1 - seno");
        Console.WriteLine("2 - coseno");
        Console.WriteLine("3 - Tangente");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Res=Math.Sin(ag*Math.PI/180);
                Console.WriteLine("El Seno es de " + Res);
                break;
            case 2:
                Res = Math.Cos(ag * Math.PI / 180);
                Console.WriteLine("El Coseno es de " + Res);
                break;
            case 3:
                Res = Math.Tan(ag * Math.PI / 180);
                Console.WriteLine("La Tangente es de"+Res);
                break;
            default:
                Console.WriteLine("Opcion no valida.");
                break;
        }
    }
}