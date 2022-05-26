using System;
using System.Collections.Generic;
using System.Linq;

namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            List<string> baskanti = new List<string>() { "paris", "damas", "moritania", "İstanbul",  };

            
            baskanti  = baskanti.Distinct().ToList(); 

            foreach (var ulke in baskanti )
            {
                Console.WriteLine(ulke);
            }
            Console.ReadLine();
        }
    }
}