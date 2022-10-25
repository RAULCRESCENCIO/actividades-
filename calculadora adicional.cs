namespace CALCULADORA_ADICIONAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            char OPCION, OPERADOR = ' ';
            //declarando e inicializando vaiables
            //se asigna el valor de 0 a las variables
            double num1 = 0, num2 = 0, num3 = 0, resultado = 0;
            Console.WriteLine("calculadora ADICIONAL");
            Console.WriteLine("OPCIONES: ");
            Console.WriteLine("S - SUMA");
            Console.WriteLine("R - RESTA");
            Console.WriteLine("D - DIVICION");
            Console.WriteLine("M - MULTIPLICACION");
            Console.WriteLine("P - RAIZ X");
            Console.WriteLine("Q - XN");
            Console.WriteLine("K - %");
            Console.WriteLine("T - MOD");
            Console.WriteLine("A - X2");
            Console.WriteLine("B - X3");
            Console.WriteLine("C - RAIZ CUADRADA");
            Console.WriteLine("D - XN");
            Console.WriteLine("E - SIN");
            Console.WriteLine("F - COS");
            Console.WriteLine("G - TAN");
            Console.WriteLine("H - LOG");
            Console.WriteLine("I - IN");
            Console.WriteLine("J - REDONDEO");
            Console.WriteLine("L - factorial");
            Console.WriteLine("SELECCIONA UNA OPCION: ");
            OPCION = char.Parse(Console.ReadLine());
            if (OPCION == 'S' || OPCION == 's' || OPCION == 'R' || OPCION == 'r' || OPCION == 'M' || OPCION == 'm' || OPCION == 'D' || OPCION == 'd' 
                || OPCION == 'K' || OPCION == 'k' || OPCION == 'P' || OPCION == 'p' || OPCION == 'Q' || OPCION == 'q'
                || OPCION == 'T' || OPCION == 't')
            {
                Console.WriteLine("INGESA EL PRIMER NUMERO: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("INGESA EL SEGUNDO NUMERO: ");
                num2 = double.Parse(Console.ReadLine());
                if (num1 <= 0 && num2 <= 0)
                {
                    Console.WriteLine("VERIFICAR LOS DATOS");
                }
                else
                    if (num1 > 0)
                {
                    switch (OPCION)
                    {
                        case 'S':
                        case 's':
                            resultado = num1 + num2;
                            OPERADOR = '+';
                            Console.WriteLine(num1 + " " + OPERADOR + " " + num2 + " " + "= " + resultado);
                            break;
                        case 'R':
                        case 'r':
                            resultado = num1 - num2;
                            OPERADOR = '-';
                            Console.WriteLine(num1 + " " + OPERADOR + " " + num2 + " " + "= " + resultado);
                            break;
                        case 'D':
                        case 'd':
                            resultado = Math.Round( num1 / num2,3);
                            OPERADOR = '/';
                            Console.WriteLine(num1 + " " + OPERADOR + " " + num2 + " " + "= " + resultado);
                            break;
                        case 'M':
                        case 'm':
                            resultado = num1 * num2;
                            OPERADOR = '*';
                            Console.WriteLine(num1 + " " + OPERADOR + " " + num2 + " " + "= " + resultado);
                            break;
                        case 'P':
                        case 'p':
                            resultado = Math.Round(Math.Pow(num2, 1 / num1), 2);
                            Console.WriteLine("raiz " + num1 + " de " + num2 + " es " + resultado);
                            break;
                        case 'Q':
                        case 'q':
                            resultado = Math.Pow(num1, num2);
                            Console.WriteLine(num1 + " al " + num2 + "es " + resultado);
                            break;
                        case 'K':
                        case 'k':
                            resultado = (num1 / 100);
                            Console.WriteLine(" el % de " + num1 + " es " + resultado);
                            break;
                        case 'T':
                        case 't':
                            resultado = num1 % num2;
                            Console.WriteLine(" el mod de " + num1 + " es " + resultado);
                            break;
                    }
                }
               
            }
            else
                if (OPCION == 'A' || OPCION == 'a' || OPCION == 'B' || OPCION == 'b' || OPCION == 'C' || OPCION == 'c' || OPCION == 'E' || OPCION == 'e' || OPCION == 'F' || OPCION == 'f'
                || OPCION == 'G' || OPCION == 'g' || OPCION == 'H' || OPCION == 'h' || OPCION == 'I' || OPCION == 'i' || OPCION == 'J' || OPCION == 'j')
            {
                Console.WriteLine("INGESA EL NUMERO: ");
                num1 = double.Parse(Console.ReadLine());
                if (num1 <= 0)
                {
                    Console.WriteLine("VERIFICAR LOS DATOS");
                }
                else
                    if(num1 > 0)
                    {
                    switch (OPCION)
                    {
                        case 'A':
                        case 'a':
                            resultado = Math.Pow(num1, 2);
                            OPERADOR = '*';
                            Console.WriteLine(num1 + " al cuadrado es " + resultado);
                            break;
                        case 'B':
                        case 'b':
                            resultado = Math.Pow(num1, 3);
                            Console.WriteLine(num1 + "al cubo es " + resultado);
                            break;
                        case 'C':
                        case 'c':
                            resultado = Math.Sqrt(num1);
                            OPERADOR = '/';
                            Console.WriteLine("raiz cuadrada de " + num1 + " es " + resultado);
                            break;
                        case 'E':
                        case 'e':
                            resultado = Math.Sin(num1);
                            Console.WriteLine("el sin de " + num1 + " es " + resultado);
                            break;
                        case 'F':
                        case 'f':
                            resultado = Math.Cos(num1);
                            Console.WriteLine("el cos de " + num1 + " es " + resultado);
                            break;
                        case 'G':
                        case 'g':
                            resultado = Math.Tan(num1);
                            Console.WriteLine("el tan de " + num1 + " es " + resultado);
                            break;
                        case 'H':
                        case 'h':
                            resultado = Math.Log10(num1);
                            Console.WriteLine("el log de " + num1 + " es " + resultado);
                            break;
                        case 'I':
                        case 'i':
                            resultado = Math.Log(num1);
                            Console.WriteLine("el in de " + num1 + " es " + resultado);
                            break;
                        case 'J':
                        case 'j':
                            resultado = Math.Round(num1);
                            Console.WriteLine("el redondeo de " + num1 + " es " + resultado);
                            break;
               
                    }
                }
            }
            else 
            if (OPCION == 'L' || OPCION == 'l')
            {
                
                Console.WriteLine("INGESA EL NUMERO: ");
               num3 = Convert.ToInt32(Console.ReadLine());

                int facorial = 1;
                for (int i = 1; i <= num3; i++)
                    facorial = facorial * i;
                Console.WriteLine("el factorial de " + num3 + " es " + facorial);
            }
            else
            {
                Console.WriteLine("VERIFICAR LA OPCION");
            }
                Console.ReadKey();

        }
    }
}