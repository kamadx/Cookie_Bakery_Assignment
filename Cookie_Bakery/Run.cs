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
            Thread tJoakim = new Thread(new ThreadStart(joakim.buyCookies));
            tJoakim.Start();

            Customer jan = new Customer("Jan", bakery);
            Thread tJan = new Thread(new ThreadStart(jan.buyCookies));
            tJan.Start();

            Customer sebastian = new Customer("Sebastian", bakery);
            Thread tSebastian = new Thread(new ThreadStart(sebastian.buyCookies));
            tSebastian.Start();

            
        }
    }
}
