using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Cookie_Bakery
{
	class CookieBakery
	{
		List<int> cookies = new List<int>();
		Stopwatch timer = new Stopwatch();
		int count = 0;

		public CookieBakery()
		{
			timer.Start();
			while (true)
			{
				if (timer.ElapsedMilliseconds >= 700)
					BakeCookie();
			}
		}

		/// <summary>
		/// Bake a cookie.
		/// </summary>
		/// <remarks>Lets see, how do these show up?</remarks>
		private void BakeCookie()
		{
			cookies.Add(count);
			Console.WriteLine("Baked cookie #{0}", count);
			count++;
			timer.Restart();
		}

		/// <summary>
		/// sells a cookie to the customer.
		/// </summary>
		/// <param name="customer"></param>
		public void sellCookieTo(Customer customer)
		{
			
		}
	}
}
