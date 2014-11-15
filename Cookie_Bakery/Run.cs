using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cookie_Bakery
{
    class Run
    {
        static void Main(string[] args)
        {
            //I tried
            CookieBakery bakery = new CookieBakery();
            Thread tBakery = new Thread(new ThreadStart(bakery.Start));
            tBakery.Start();

            Customer joakim = new Customer("Joakim", bakery);
            Thread tJoakim = new Thread(new ThreadStart(joakim.checkForCookie));
            tJoakim.Start();

            Customer jan = new Customer("Jan", bakery);
            Thread tJan = new Thread(new ThreadStart(jan.checkForCookie));
            tJan.Start();

            Customer sebastian = new Customer("Sebastian", bakery);
            Thread tSebastian = new Thread(new ThreadStart(sebastian.checkForCookie));
            tSebastian.Start();

            
        }
    }
}
