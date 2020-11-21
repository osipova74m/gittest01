using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest01
{
    class Program
    {
        public static int Version { get; set; } = 5;
        static void Main(string[] args)
        {
            Console.WriteLine($"Application version is: {Version}");

            var sin = Math.Sin(30.0);
            Console.WriteLine($"Sin 30 = {sin}");
                 

            Console.ReadLine();
        }
    }
}
