using System;
namespace Geometria
{
    class Punto
    {
        public Punto(uint x, uint y)
        {
            this.X = x;
            this.Y = y;
        }
        public readonly uint X;
        public readonly uint Y;
    }
    class Cuadrado
    {
        public Cuadrado(Punto vert1, uint lado)
        {
            this.vertice1 = vert1;
            this.lado = lado;
        }
        public Cuadrado(Punto vert1, Punto vert3)
        {
            this.vertice1 = vert1;
            this.lado = (uint)Math.Abs(vert3.X - vert1.X);
        }
        protected Punto vertice1;
        protected uint lado;
        public Punto Vertice1
        {
            get
            {
                return this.vertice1;
            }
        }
        public Punto Vertice2
        {
            get
            {
                Punto p = new Punto(this.vertice1.X + this.lado, this.vertice1.Y);
                return p;
            }
        }
        public Punto Vertice3
        {
            get
            {
                Punto p = new Punto(this.vertice1.X + this.lado, this.vertice1.Y + this.lado);
                return p;
            }
        }
        public Punto Vertice4
        {
            get
            {
                Punto p = new
                    Punto(this.vertice1.X, this.vertice1.Y + this.lado);
                return p;

            }
        }
        public uint Lado
        {
            get
            {
                return this.lado;
            }
            set
            {
                this.lado = value;
            }
        }
        public uint Perimetro
        {
            get
            {
                return this.lado * 4;
            }
        }
        public uint Area
        {
            get
            {
                return (uint)Math.Pow(this.lado, 2);
            }
        }
    }
}
namespace PruebaGeometria
{
    using Geometria;
    class GeometriaApp
    {
        static void PropCuadrado(Cuadrado cuad)
        {
            Console.WriteLine("Coordenadas de los vértices del cuadrado:");
            Console.WriteLine("Vértice 1: ({0},{1})",
                cuad.Vertice1.X, cuad.Vertice1.Y);
            Console.WriteLine("Vértice 2: ({0},{1})",
               cuad.Vertice2.X, cuad.Vertice2.Y);
            Console.WriteLine("Vértice 3: ({0},{1})",
               cuad.Vertice3.X, cuad.Vertice3.Y);
            Console.WriteLine("Vértice 4: ({0},{1})",
               cuad.Vertice4.X, cuad.Vertice4.Y);
            Console.WriteLine("Longitud del lado: {0}",
                cuad.Perimetro);
            Console.WriteLine("Perímetro: {0}",
                cuad.Perimetro);
            Console.WriteLine("Área: {0}",
                cuad.Area);
            Console.WriteLine("Pulsa INTRO para continuar");

            string a = Console.ReadLine();

        }
        static void Main()
        {
            uint x, y;
            Cuadrado cuadrado;
            Punto p1, p2;
            uint lado;
            Console.WriteLine("Cuadrado a partir del lado y un vértice");
            Console.Write("Escribe componente X del vértice: ");
            x = UInt32.Parse(Console.ReadLine());
            Console.Write("Escribe la longitud del lado: ");
            lado = UInt32.Parse(Console.ReadLine());

            p1 = new Punto(x, y);
            cuadrado = new Cuadrado(p1, lado);
            Console.WriteLine("Construido el cuadrado. Pulsa INTRO para ver sus propiedades");
            string a = Console.ReadLine();
            PropCuadrado(cuadrado);
            Console.WriteLine("Cuadrado a partir de dos vértices");
            Console.Write("Escribe componente X del vértice1: ");
            x = UInt32.Parse(Console.ReadLine());
            Console.Write("Escribe componente Y del vértice1: ");
            y = UInt32.Parse(Console.ReadLine());
            p1 = new Punto(x, y); 
            Console.Write("Escribe componente X del vértice3: ");
            x = UInt32.Parse(Console.ReadLine());
            Console.Write("Escribe componente Y del vértice3: ");
            y = UInt32.Parse(Console.ReadLine());
            p2 = new Punto(x, y);
            cuadrado = new Cuadrado(p1, p2);
            Console.WriteLine("Construido el cuadrado. Pulsa INTRO para ver sus propiedades");
            a = Console.ReadLine();
            PropCuadrado(cuadrado); 
        }
    }
}
