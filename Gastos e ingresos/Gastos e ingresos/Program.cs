
using System;

namespace CircunferenciaMetodos
{
    class Circunferencia
    {
        public Circunferencia(double rad)
        {
            this.radio = rad;
        }

        protected double radio;

        const double PI = 3.1415926;

        public double Radio()
        {
            return this.radio;
        }

        public void Radio(double rad)
        {
            this.radio = rad;
        }

        public double Perimetro()
        {
            return 2 * PI * this.radio;
        }

        public double Area()
        {
            return PI * Math.Pow(this.radio, 2);
        }
    }

    class CircunferenciaApp
    {
        static void Main()
        {
            Circunferencia c = new Circunferencia(4);

            Console.WriteLine("El radio de la circunferencia es {0}", c.Radio());
            Console.WriteLine("El perímetro de la circunferencia es {0}",
                c.Perimetro());
            Console.WriteLine("El área de la circunferencia es {0}", c.Area());
            Console.WriteLine("Pulsa INTRO para incrementar el radio en 1");
            string a = Console.ReadLine();

            c.Radio(c.Radio() + 1);
            Console.WriteLine("El radio de la circunferencia es {0}", c.Radio());
            Console.WriteLine("El perímetro de la circunferencia es {0}",
                c.Perimetro());
            Console.WriteLine("El área de la circunferencia es {0}", c.Area());

            a = Console.ReadLine();
        }
    }
}
