using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Cookie_Bakery
{
	class Customer
	{
		string name;
		public List<int> cookies;
		Stopwatch timer;
		CookieBakery bakery;

		public Customer(string name, CookieBakery bakery)
		{
			cookies = new List<int>();
			timer = new Stopwatch();
			this.name = name;
			this.bakery = bakery;
		}

        /// <summary>
        /// Buys a cookie
        /// </summary>
		public void buyCookies()
		{
			timer.Start();
			while (true)
			{
				if (timer.ElapsedMilliseconds >= 1000)
				{
					lock (bakery)
					{
						if (bakery.cookies.Count >= 1)
						{
							bakery.sellCookieTo(this);
                            Console.WriteLine("\t\t\t" + name + " bought cookie #{0}.", cookies[cookies.Count - 1]);
						}
					}
					timer.Restart();
				}
			}
		}
	}
}
