namespace BANDIDO_DE_PELUCHE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SA = 0, MCR, PGD, SAN = 0, ITS, MULT, PAGM, PAGNI;

            Console.WriteLine("Programa para calcular el pago minimo, saldo actual y no generar intereses");
            Console.WriteLine("Ingrese el saldo anterior");
            SA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto de compras que realizo");
            MCR = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el pago que deposito en el corte anterior");
            PGD = double.Parse(Console.ReadLine());

            if (SA * .015 > PGD)
            {
                ITS = SA * 0.12;
                MULT = 200;
            }
            else
            {
                ITS = 0;
                MULT = 0;
            }
            SA = SAN + MCR - PGD + ITS + MULT;
            PAGM = SA * 0.15;
            PAGNI = SA * 0.85;
            Console.WriteLine("El valor del saldo actual es:" + SA);
            Console.WriteLine("El valor del pago minimo es de:" + PAGM);
            Console.WriteLine("El valor del pago para no generar intereses es de:" + PAGNI);
            Console.WriteLine("El valor de los intereses son de:" + ITS);
            Console.WriteLine("El valor de la multa es:" + MULT);
            Console.ReadKey();

        }
    }
}