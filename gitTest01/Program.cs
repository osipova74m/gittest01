using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest01
{
    class Program
    {
        public static int Version { get; set; } = 1;
        static void Main(string[] args)
        {
            Console.WriteLine($"Application version is: {Version}");
            Console.ReadLine();
        }
    }
}
