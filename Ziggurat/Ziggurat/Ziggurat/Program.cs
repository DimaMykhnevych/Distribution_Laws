using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziggurat
{
    class Program
    {
        static void Main(string[] args)
        {
            ZigguratGaussianSampler zig = new ZigguratGaussianSampler();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Нормальное распределение (Зиккрурат-алгоритм): " + zig.NextSample());
            Console.ReadKey();
        }
    }
}
