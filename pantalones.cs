namespace fabrica_de_pantalones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char M;
            int T = 0, N = 0;
            double PPN = 0, C = 0, MDO = 0, TMDO = 0, GDT = 0,GNP = 0,GDT2 = 0,GDT3 = 0,GDT4 = 0;
            Console.WriteLine("MODELO DE PANTLON");
            M = char.Parse(Console.ReadLine());
            Console.WriteLine("TALLA DE LOS PANTLONES");
            T = int.Parse(Console.ReadLine());
            Console.WriteLine("NUMERO DE PANTALONES");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("COSTO POR METRO DE TELA");
            PPN = double.Parse(Console.ReadLine());

            if (M == 'A' && T == 30)
            {
                C = (PPN * 1.5);
                MDO = (C * 0.8);
                TMDO = C + MDO;
                GDT = TMDO * 0.3;
                GDT2 = TMDO + GDT; 
                GNP = GDT * N;
                Console.WriteLine("PRECIO FINAL DE VENTA ES: " + GDT2);
                Console.WriteLine("GANANCIA POR NUMERO DE PNTALONES ES: " + GNP);
            }
            else
                if (M == 'A' && T == 32)
            {
                C = (PPN * 1.5);
                MDO = (C * 0.8);
                TMDO = C + MDO;
                GDT = TMDO * 0.04;
                GDT2 = TMDO + GDT;
                GDT3 = GDT2 * 0.3;
                GDT4 = GDT3 + GDT2;
                GNP = (GDT4 - TMDO) * N;
                Console.WriteLine("PRECIO FINAL DE VENTA ES: " + GDT4);
                Console.WriteLine("GANANCIA POR NUMERO DE PNTALONES ES: " + GNP);
            }
            else
                if (M == 'A' && T == 36)
            {
                C = (PPN * 1.5);
                MDO = (C * 0.8);
                TMDO = C + MDO;
                GDT = TMDO * 0.04;
                GDT2 = TMDO + GDT;
                GDT3 = GDT2 * 0.3;
                GDT4 = GDT3 + GDT2;
                GNP = (GDT4 - TMDO) * N;
                Console.WriteLine("PRECIO FINAL DE VENTA ES: " + GDT4);
                Console.WriteLine("GANANCIA POR NUMERO DE PNTALONES ES: " + GNP);
            }
            else
                if (M == 'B' && T == 30)
            {
                C = (PPN * 1.8);
                MDO = (C * 0.95);
                TMDO = C + MDO;
                GDT = TMDO * 0.3;
                GDT2 = TMDO + GDT;
                GNP = GDT * N;
                Console.WriteLine("PRECIO FINAL DE VENTA ES: " + GDT2);
                Console.WriteLine("GANANCIA POR NUMERO DE PNTALONES ES: " + GNP);
            }
            else
                if (M == 'B' && T == 32)
            {
                C = (PPN * 1.8);
                MDO = (C * 0.95);
                TMDO = C + MDO;
                GDT = TMDO * 0.04;
                GDT2 = TMDO + GDT;
                GDT3 = GDT2 * 0.3;
                GDT4 = GDT3 + GDT2;
                GNP = (GDT4 - TMDO) * N;
                Console.WriteLine("PRECIO FINAL DE VENTA ES: " + GDT4);
                Console.WriteLine("GANANCIA POR NUMERO DE PNTALONES ES: " + GNP);
            }
            else
                if (M == 'B' && T == 36)
            {
                C = (PPN * 1.8);
                MDO = (C * 0.95);
                TMDO = C + MDO;
                GDT = TMDO * 0.04;
                GDT2 = TMDO + GDT;
                GDT3 = GDT2 * 0.3;
                GDT4 = GDT3 + GDT2;
                GNP = (GDT4 - TMDO) * N;
                Console.WriteLine("PRECIO FINAL DE VENTA ES: " + GDT4);
                Console.WriteLine("GANANCIA POR NUMERO DE PNTALONES ES: " + GNP);
            }
            else
            if (N <= 0)
            {
                Console.WriteLine("VERIFIQUE EL NUMERO DE PANTALONES");
            }
            else
            if (PPN <= 0)
            {
                Console.WriteLine("VERIFIQUE EL PRECIO DE LA TELA");
            }
            else
            {
                Console.WriteLine("VERIFIQUE LOS DATOS DE ENTRADA");
            }
        }
    }
}