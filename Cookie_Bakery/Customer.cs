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
        List<int> cookies;
        Stopwatch timer;


        public Customer(string name) 
        {
            this.name = name;
        }

        public void checkForCookie()
        {
            timer.Start();
            int cookieNumber;
            
        }
	}
}
