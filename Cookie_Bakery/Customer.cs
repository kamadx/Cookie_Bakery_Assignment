using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Cookie_Bakery
{
	class Customer
	{
        string name;
        public List<int> cookies = new List<int>();
        Stopwatch timer;


        public Customer(string name, CookieBakery bakery) 
        {
            this.name = name;
            timer.Start();
            while (true)
            {
                if (timer.ElapsedMilliseconds >= 1000)
                {
                    checkForCookie(bakery);
                }
                timer.Restart();
            }
        }


        public void checkForCookie(CookieBakery bakery)
        {
            if (cookies.Count >= 1)
            {
                bakery.sellCookieTo(this);
                Console.WriteLine("\t" + name + " bought cookie #{0}.", cookies[cookies.Count-1]);
            }
        }
	}
}
