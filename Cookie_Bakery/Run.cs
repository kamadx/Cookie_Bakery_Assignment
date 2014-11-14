using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Bakery
{
    class Run
    {
        static void Main(string[] args)
        {

            CookieBakery bakery = new CookieBakery();
            Customer Joakim = new Customer("Joakim", bakery);
            Customer Jan = new Customer("Jan", bakery);
            Customer Sebastian = new Customer("Sebastian", bakery);

        }
    }
}
