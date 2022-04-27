using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Liskov_Subtitution_Principle
{
    /// <summary>
    /// Liskov Subtitution Principle
    /// Alt seviye sınıflardan oluşan nesnelerin/sınıfların, ana(üst) sınıfın 
    /// nesneleri ile yer değiştirdikleri zaman, aynı davranışı sergilemesi gerekmektedir.
    /// Türetilen sınıflar, türeyen sınıfların tüm özelliklerini kullanabilmelidir.
    /// Kare - Dikdörtgen - Interface
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(8);
            Dikdortgen dikdortgen  = new Dikdortgen(8,4);

            Console.WriteLine(kare.alan().ToString());
            Console.WriteLine(dikdortgen.alan().ToString());
            Console.ReadKey();
        }
    }
    interface sekil
    {
        long alan();
    }
    class Kare : sekil
    {
        private int x;

        public int XX
        {
            get { return x; }
            set { x = value; }
        }


        public Kare(int Xx)
        {
            x = Xx;
        }
        
        public long alan()
        {
            return x * x;
        }
    }

    class Dikdortgen : sekil
    {
        private int x;

        public int XX
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int YY
        {
            get { return y; }
            set { y = value; }
        }

        public Dikdortgen(int xx, int yy)
        {
            x = xx;
            y = yy;
        }


        public long alan()
        {
            return x * y;
        }
    }
}
