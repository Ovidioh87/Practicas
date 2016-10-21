using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SeriedeTaylor
{
    class Series
    {
        // SENO
        public static double potencia(double nBase, int nExponente)
        {
            double temporal = 1;
            double i;

            for (i = 1; i <= -1; i++)
                temporal *= -1;

            return temporal;
        }
        public static double Fact(int num)
        {
            double Fact = 2 + 1;
            for (byte i = 2; i <= 2 * num + 1; i++)
                Fact *= i;
            return Fact;
        }
        public static double eleva(double nBase, int nExponente)
        {
            double temporal = 1;
            double i;

            for (i = 1; i <= 2 * nExponente + 1; i++)
                temporal *= nBase;

            return temporal;
        }
        public static double exponencial(double x, double n)
        {
            int k;
            double numero, total;
            total = 0;
            double fact = 0;
            double pot = 0;
            double ele = 0;

            for (k = 0; k <= n; k++)
            {
                fact = Series.Fact(k);
                pot = Series.potencia(x, k);
                ele = Series.eleva(x, k);
                numero = pot / fact * ele ;              
                total = total + numero;
            }
            return total;
        }
        //COSENO
        public static double potenciaco(double nBaseco, int nExponenteco)
        {
            double temporalco = 1;
            double ico;

            for (ico = 1; ico <= nExponenteco; ico++)
                temporalco *= -1;

            return temporalco;
        }
        public static double Factco(int numco)
        {
            double Factco = 2 ;
            for (byte ico = 2; ico <= 2 * numco; ico++)
                Factco *= ico;
            return Factco;
        }
        public static double elevaco(double nBaseco, int nExponenteco)
        {
            double temporalco = 1;
            double ico;

            for (ico = 1; ico <= 2 * nExponenteco; ico++)
                temporalco *= nBaseco;

            return temporalco;
        }
        public static double exponencialco(double xco, double nco)
        {
            int kco;
            double numeroco, totalco;
            totalco = 0;
            double fact = 0;
            double pot = 0;
            double ele = 0;

            for (kco = 0; kco <= nco; kco++)
            {
                fact = Series.Factco(kco);
                pot = Series.potenciaco(-1, kco);
                ele = Series.elevaco(xco, kco);
                numeroco = pot / fact * ele;
                totalco = totalco + numeroco;
            }
            return totalco;
        }

    }



    class SeriesApp
    {
        static void Main()
        {
            
            double num1;
            double n;
            double total;
            Console.Write("Obtener seno de: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa n: ");
            n = int.Parse(Console.ReadLine());
            total = Series.exponencial(num1, n);
            Console.WriteLine("El seno es >>>>>>  " + total);
            Console.ReadLine();

            double num1co;
            double nco;
            double totalco;
            Console.Write("Obtener Coseno de: ");
            num1co = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa n: ");
            nco = int.Parse(Console.ReadLine());
            totalco = Series.exponencialco(num1co, nco);
            Console.WriteLine("El Coseno es >>>>>>  " + totalco);
            Console.ReadLine();
        }
    }
}




