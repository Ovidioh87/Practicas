using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLIGRAFO
{
    class Boligrafo
    {
        protected int color = 0;
        protected byte tinta = 100;
        public bool Pintar (byte gasto)
        {
            if (gasto > this.tinta) return false;
            this.tinta -= gasto;
            Console.WriteLine("Se gastaron {0} unidades de tinta.", gasto);
            return true;
       
        }
        public void Recargar()
        {
            this.tinta = 100;
            Console.WriteLine("Bolígrafo recargado.");
        }
        public int Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public byte Tinta
        {
            get
            {
                return this.tinta;
            }
        }
        class BoligrafoApp
        {
            static void Main()
            {
                // Instanciación del objeto
                Boligrafo boli = new Boligrafo();
                Console.WriteLine("El boli tiene {0} unidades de tinta", boli.Tinta);

                Console.WriteLine("boli.Pintar(50) devuelve {0}", boli.Pintar(50));
                Console.WriteLine("Al boli le quedan {0} unidades de tinta", boli.Tinta);

                Console.WriteLine("boli.Pintar(60) devuelve {0}", boli.Pintar(60));
                Console.WriteLine("Al boli le quedan {0} unidades de tinta", boli.Tinta);

                boli.Recargar();
                Console.WriteLine("Al boli le quedan {0} unidades de tinta", boli.Tinta);

                string a = Console.ReadLine();
            }
        }

    }
}
