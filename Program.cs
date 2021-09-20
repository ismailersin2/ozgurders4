using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozgurders4
{
    class Program
    {

        public static void merhabaYaz()
        {
            Console.WriteLine("Selamlar");
        }
        public static void topla(int a, int b)
        {
            int sonuc = a + b;
            Console.WriteLine($"{a}+{b}={sonuc}");
        }
        public static void cikarma(int c, int d)
        {
            int sonuc = c - d;
            Console.WriteLine($"{c}-{d}={sonuc}");
        }

        public static float daireAlan(float r)
        {

            float alan = ((float)22 / 7) * r * r;
            return alan;
        }

        public static float kareAlan(float a)
        {
            float alan = (a * a);
            return alan;
        }

        public static float dikdortgenAlan(float a, float b)
        {
            float alan = (a * b);
            return alan;
        }

        public static bool IsOdd(int a)
        {
            if (a % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //girilen sayının asal olup olmadığını bulan program





        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba");
            merhabaYaz();
            merhabaYaz();
            merhabaYaz();
            merhabaYaz();
            merhabaYaz();
            merhabaYaz();
            merhabaYaz();
            topla(6, 9);
            int x = 5;
            int y = 10;
            topla(x, y);
            Console.WriteLine("Önce eksileni, sonra çıkanı yazınız");
            int z, w;
            z = Convert.ToInt16(Console.ReadLine());
            w = Convert.ToInt16(Console.ReadLine());
            cikarma(z, w);
            Console.WriteLine("Yarıçap:");
            float ycap = float.Parse(Console.ReadLine());
            float dalan =daireAlan(ycap);
            Console.WriteLine($"yarıçapı {ycap} olan dairenin alanı {dalan}");

            Console.WriteLine("Bir sayı giriniz");
            int m = Convert.ToInt16(Console.ReadLine());

            if (IsOdd(m))
            {
                Console.WriteLine("sayı tek");
            }
            else
            {
                Console.WriteLine("sayı çift");
            }



        }
    }
}
