using System;

public class rastgele
{
	static void Main(string[] args)
	{


		/* sayi tahmin oyunu 
		 * program  rastgele  bir sayi uretir 
		 * kullanicidan bir sayi istenir 
		 * girilen tahmine gore yukari yada asagi biciminde yonlendirir 
		 * sayi bilenene kadar 2.adim tekrarlanir */
		Random RandomNumberGenerator = new Random();
		int number = RandomNumberGenerator.Next(1, 100);
		bool isgamefinished = false;
		{
			while (isgamefinished == false) {

				Console Writeline("Tahmini giriniz ");
				new guess = Convert.ToInt32(Console.ReadLine());
				if (guess > number)
				{ Console Writeline("yukari "); }

				else if (number > guess)
				{ Console Writeline( " asagi "); }


				else { (Console Writeline("Dogru ");
					isgamefinished = true;
				}


			}
		}


	}
}
