using System;

namespace Euler10
{
	class MainClass
	{
		public static void Main (string[] args)
		{ 
			int tm = 20000000;
			int t = 1;
			int sum = 0;

			while (t < tm) {
				if (t % 2 != 0 | t % 3 != 0) {
					sum += t;
					t++;
				} else {
					t++;
				}
			}

			Console.WriteLine ("The sum of the prime numbers below two million is: " + sum);
		} 
	}
}
