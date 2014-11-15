﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Cookie_Bakery
{
	class Customer
	{
		string name;
		public List<int> cookies = new List<int>();
		Stopwatch timer = new Stopwatch();
        CookieBakery bakery;

		public Customer(string name, CookieBakery bakery)
		{
			this.name = name;
            this.bakery = bakery;
		}

        public void checkForCookie()
		{
            while (true)
            {
				if (cookies.Count >= 1)
				{
                    lock (bakery)
                    {
                
				    bakery.sellCookieTo(this);
				    Console.WriteLine("\t" + name + " bought cookie #{0}.", cookies[cookies.Count - 1]);
			        }
		        }
            }		
		}
	}
}
