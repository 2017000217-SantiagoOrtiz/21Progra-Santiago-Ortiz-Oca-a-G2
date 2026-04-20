internal class Program
{
    private static void Main(string[] args)
    {
        double sinIva = 650.00;
        double conIva = sinIva * 1.12;
        double pd = 0.00;
        String fp = "";

        Console.Write("Cantidad de impresoras: ");
        int cant = int.Parse(Console.ReadLine());

        Console.WriteLine("Elija su metodo de pago");
        Console.WriteLine("1 Efectivo - 10% desc");
        Console.WriteLine("2 Tarjeta de credito - 5% desc");
        Console.WriteLine("3 Vale de regalo - 15% desc");
        int op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                pd = 0.10;
                fp = "Efectivo";
                break;
            case 2:
                pd = 0.05;
                fp = "Tarjeta de credito";
                break;
            case 3:
                pd = 0.15;
                fp = "Vale de regalo";
                break;
            default:
                pd = 0.00;
                fp = "No valida, Sin descuento";
                break;
        }

        double tosd = conIva * cant;
        double d = tosd * pd;
        double tp = tosd - d;
        Console.WriteLine("           Detalles de Pago             ");
        Console.WriteLine("Cantidad comprada:          " + cant);
        Console.WriteLine("Precio unitario (con IVA):  Q" + conIva);
        Console.WriteLine("Total sin descuento:        Q" + tosd);
        Console.WriteLine("Forma de pago elegida:      " + fp);
        Console.WriteLine("Descuento realizado:        -Q" + d);
        Console.WriteLine("Total a pagar:              Q" + tp);

    }
}