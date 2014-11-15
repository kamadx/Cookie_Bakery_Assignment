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

        public void start()
        {

            timer.Start();
            while (count <= 5)
            {
                if (timer.ElapsedMilliseconds >= 700)
                {
                    bakeCookie();
                    timer.Restart();
                }
            }
            Console.WriteLine("\nHurry, this is the last Cookie!\n");
        }

        /// <summary>
        /// Bakes a cookie and adds it to the list of cookies.
        /// </summary>
        private void bakeCookie()
        {
            cookies.Add(count);
            Console.WriteLine("Baked cookie #{0}.", count);
            count++;
        }

        /// <summary>
        /// Sells cookie to Customer
        /// and removes the last made cookie in the list of cookies
        /// </summary>
        public void sellCookieTo(Customer customer)
        {
            customer.cookies.Add(cookies[0]);
            cookies.RemoveAt(0);
        }

    }
}
