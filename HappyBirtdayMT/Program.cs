using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HappyBirtdayMT
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 3; i++)
            {
                Console.WriteLine(((i == 2) ? "Gratulerer kjære Morten..!" : "Gratulerer med dagen!"));
                Thread.Sleep(500);
            }
            Console.WriteLine("This message will self destruct in 5 sec.");
            Thread.Sleep(5000);
        }
    }
}
