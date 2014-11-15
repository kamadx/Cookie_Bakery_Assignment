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

			Thread tJoakim = new Thread(new ThreadStart(new Customer("Joakim", bakery).buyCookies));
			tJoakim.Start();

			Thread tJan = new Thread(new ThreadStart(new Customer("Jan", bakery).buyCookies));
			tJan.Start();

			Thread tSebastian = new Thread(new ThreadStart(new Customer("Sebastian", bakery).buyCookies));
			tSebastian.Start();


		}
	}
}
