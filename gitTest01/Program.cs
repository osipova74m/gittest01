using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest01
{
    class Program
    {
        public static int Version { get; set; } = 10;
        static void Main(string[] args)
        {
            Console.WriteLine($"Application version is: {Version}");

            var sin = Math.Sin(30);
            Console.WriteLine($"Sin 30 = {sin}");

            var sin45 = Math.Sin(45);
            Console.WriteLine($"Sin 45 = {sin45}");


            Console.ReadLine();
        }
    }
}
