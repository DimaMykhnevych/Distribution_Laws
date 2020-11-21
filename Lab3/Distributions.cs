using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Distributions
    {
        public static double UniformDistribution(double a, double b)
        {
            Random r = new Random();
            return r.NextDouble() * (b - a) + a;
        }

        //экспоненциальное распределение
        public static double ExponentialDistribution()
        {
            Random r = new Random();
            return -Math.Log(r.NextDouble()) / 5;
        }

        //нормальное распределение
        public static double GaussianDistribution(double mu = 0, double sigma = 1)
        {
            Stopwatch swatch = new Stopwatch();
            swatch.Start();

            Random r = new Random();
            var u1 = r.NextDouble();
            var u2 = r.NextDouble();

            //var rand_std_normal = Math.Abs(Math.Abs(Math.Sqrt(-2.0 * Math.Log(u1)) *
            //                    Math.Sin(2.0 * Math.PI * u2)) - 1);

            var x = Math.Sqrt(-2.0 * Math.Log(u1)) *
                               Math.Sin(2.0 * Math.PI * u2);

            var rand_normal = 1 / Math.Sqrt(2.0 * Math.PI) *
                                Math.Pow(Math.E, -(x * x) / 2);

            //var rand_normal = mu + sigma * rand_std_normal;

            swatch.Stop(); // стоп
            Console.WriteLine("Время выполнения: {0}", swatch.Elapsed);

            return rand_normal;
        }

        //нормальное распределение(зиккурат-алогритм)
        public static double ZigguratNormalDistibution()
        {
            ZigguratGaussianSampler zig = new ZigguratGaussianSampler();
            Random rnd = new Random();
            var res =  zig.NextSample();
            if(Math.Abs(res) > 1)
            {
                return rnd.NextDouble();
            }
            return Math.Abs(res);
        }
    }
}
