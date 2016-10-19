using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriedeTaylor
{
    class Series
    {
            public static double potencia(double nBase, int nExponente)
        {
            double temporal = 1;        
            double i;                  

            for (i = 1; i <= nExponente; i++)    
                temporal *= nBase;           

            return temporal;               
        }
        public static double Fact(int num)
        {
            double Fact = 1;
            for (byte i = 2; i <= num; i++)
                Fact *= i;
            return Fact;
        }
        public static double exponencial (double x,double n)
        {
            int  k;
            double numero, total;
            total = 0;
            double fact = 0;
            double pot = 0;

            for (k = 0; k <= n; k++)
            {                
                fact = Series.Fact(k);
                pot = Series.potencia(x, k);
                numero = pot / fact;
                total = total + numero;                
            }
            return total;
        }
    }
    class SeriesApp
    {
        static void Main()
        {           
                double num1;
                double n;
                double total;                
                Console.Write("Introduzca la base: ");
                num1 = Convert.ToInt32(Console.ReadLine());                   
            Console.Write("Ingresa n: ");
            n = int.Parse(Console.ReadLine());
            total = Series.exponencial(num1, n);
            Console.WriteLine("La exponencial es >>>>>>  " + total);
            Console.ReadLine();
        
        }
    }
}

  
 
    
 


