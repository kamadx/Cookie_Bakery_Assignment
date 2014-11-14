using System;
using System.Collections.Generic;
using System.Diagnostics;





namespace Cookie_Bakery
{
	class CookieBakery
	{
		public List<int> cookies = new List<int>();
		private Stopwatch timer = new Stopwatch();
		private int count = 0;

		public CookieBakery() { }

		private void Start()
		{

			timer.Start();
			while (true)
			{
				if (timer.ElapsedMilliseconds >= 700)
				{
					BakeCookie();
					timer.Restart();
				}
			}
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
