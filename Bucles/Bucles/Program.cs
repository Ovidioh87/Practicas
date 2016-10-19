using System;

namespace EjercicioCSharp
{
    class Metodos
    {
        public static double rFact(byte num)
        {
            return (num == 0) ? 1 : num * rFact((byte)(num - 1));
        }
        public static double itFact(byte num)
        {
            double Fact = 1;
            for (byte i = 2; i <= num; i++)
                Fact *= i;
            return Fact;
        }

        public static ulong rMCD(ulong num1, ulong num2)
        {
            ulong mayor = (num1 > num2) ? num1 : num2;
            ulong menor = (num1 > num2) ? num2 : num1;
            return (mayor == menor ? mayor : rMCD(mayor - menor, menor));
        }

        public static ulong itMCD(ulong num1, ulong num2)
        {
            ulong mayor = (num1 > num2) ? num1 : num2;
            ulong menor = (num1 > num2) ? num2 : num1;

            if (mayor == menor) return mayor;
            ulong MCD = mayor / 2;
            while (mayor % MCD != 0 || menor % MCD != 0)
            {
                MCD -= 1;
            }
            return MCD;
        }
        public static ulong MCM(ulong num1, ulong num2)
        {
            ulong mayor = (num1 > num2) ? num1 : num2;
            ulong menor = (num1 > num2) ? num2 : num1;
            ulong mcm = mayor;
            while (mcm % menor != 0)
                mcm += mayor;

            return mcm;

        }
        public static bool EsPerfecto(ulong num)
        {
            ulong sumadiv = 0;
            for (ulong i = 1; i <= num / 2; i++)
                sumadiv += (num % i == 0) ? i : 0;
            return sumadiv == num;
        }
    }
        
class MetodosApp
{
    static void Main()
    {
        ulong num1 = 0;
        ulong num2 = 0;
        
      
        do
        {
            try
            {
                Console.Write("Dame un número para calcular el factorial: ");
                num1 = UInt64.Parse(Console.ReadLine());
            }
            catch
            {
                continue;
            }
        } while (num1 > 255);
        Console.WriteLine("El método rFact dice que el factorial de {0} es {1}",
            num1,Metodos.rFact((byte) num1));
        Console.WriteLine("El método itFact dice que el factorial de {0} es {1}",
            num1, Metodos.itFact((byte)num1));
                Console.WriteLine();

                do
                {
                    try
                    {
                        Console.Write("Ahora dame un número para MCD Y MCM: ");
                        num1 = UInt64.Parse(Console.ReadLine());
                        Console.Write("Ahora dame el otro número para MCD Y MCM: ");
                        num2 = UInt64.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        continue;
                    }
                } while (num1 == 0 || num2 == 0);
                Console.WriteLine("El ,método rMCD dice que el MCD entre {0} y {1} es {2}",
                    num1, num2, Metodos.rMCD(num1, num2));
                Console.WriteLine("El método itMCD dice que MCD entre {0} y {1} es {2}", 
                    num1, num2, Metodos.itMCD(num1,num2));
                Console.WriteLine();

                Console.WriteLine("El método MCM dice que el MCM entre {0} y {1} es {2}",
                    num1,num2,Metodos.MCM(num1,num2));
                Console.WriteLine();
                do
                {
                    try
                    {
                        Console.Write("Por fin, dame un número para ver si es PERFECTO: ");
                        num1 = UInt64.Parse(Console.ReadLine());

                    }
                    catch
                    {
                        continue;
                    }
                } while (num1>0);
                Console.WriteLine("El método EsPerfecto dice que el número {0} {1}",
                num1,  Metodos.EsPerfecto(num1) ? "es perfecto": "no es perfecto");
                
 
            string a=Console.ReadLine();  
            }
        }
    }
}