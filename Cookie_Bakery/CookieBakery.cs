using System;
using System.Collections.Generic;
using System.Diagnostics;





namespace Cookie_Bakery
{
	class CookieBakery
	{
		public List<int> cookies;
		private Stopwatch timer;
		private int count;

		public CookieBakery() 
		{
			cookies = new List<int>();
			timer = new Stopwatch();
			count = 0;
		}

		public void Start()
		{

			timer.Start();
			while (count <= 70)
			{
				if (timer.ElapsedMilliseconds >= 700)
				{
					BakeCookie();
					timer.Restart();
				}
			}
            Console.WriteLine("\nHurry, this is the last Cookie!\n");
		}

		/// <summary>
		/// Bake a cookie.
		/// </summary>
		/// <remarks>Lets see, how do these show up?</remarks>
		private void BakeCookie()
		{
			cookies.Add(count);
			Console.WriteLine("Baked cookie #{0}.", count);
			count++;
		}

		/// <summary>
		/// sells a cookie to a customer.
		/// </summary>
		/// <param name="customer"></param>
		public void sellCookieTo(Customer customer)
		{
			customer.cookies.Add(cookies[0]);
			cookies.RemoveAt(0);
		}

	}
}
