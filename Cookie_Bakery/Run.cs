using System.Threading;

namespace Cookie_Bakery
{
    class Run
    {
        static void Main(string[] args)
        {
            CookieBakery bakery = new CookieBakery();
            Thread tBakery = new Thread(new ThreadStart(bakery.start));
            tBakery.Start();

            Thread tJoakim = new Thread(new ThreadStart(new Customer("Joakim", bakery).buyCookies));
            tJoakim.Start();

            Thread tJan = new Thread(new ThreadStart(new Customer("Jan", bakery).buyCookies));
            tJan.Start();

            Thread tSebastian = new Thread(new ThreadStart(new Customer("Sebastian", bakery).buyCookies));
            tSebastian.Start();
        }
    }
}
