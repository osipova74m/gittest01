using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest01
{
    class Program
    {
        public static string Version { get; set; } = "7c";
        static void Main(string[] args)
        {
            Console.WriteLine($"Application version is: {Version}");

            var cos = Math.Cos(30.0);
            Console.WriteLine($"Cos 30 = {cos}");
                 

            Console.ReadLine();
        }
    }
}
