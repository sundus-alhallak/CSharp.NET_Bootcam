using System;

namespace FreeFall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("serbest dusme formulu");

                Console.Write("Hava Sürtünme Katsayısını Giriniz.");
                double katsa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write(" Yerçekimini giriniz");
                double cekim = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("cisim kutlesini giriniz");
                double kutle = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("istediginiz saniyede hizi");
                double zaman = Convert.ToDouble(Console.ReadLine());
                
                double result = (((cekim * kutle) / katsa) * (1 - (Math.Exp((katsa/ kutle) *zaman  * (-1)))));
                Console.WriteLine("Sonuç : " + result+"m/s");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Lütfen ilgili değerlere sayısal değer yazınız.");
                Console.WriteLine(e);
            }
        }
    }
}