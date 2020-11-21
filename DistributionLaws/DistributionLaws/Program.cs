using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Ziggurat;

namespace DistributionLaws
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Равномерное распределение: " + UniformDistribution(3, 10));
            Console.WriteLine();
            Console.WriteLine("Экспоненциальное распределение: " + ExponentialDistribution());
            Console.WriteLine();
            Console.WriteLine("Нормальное распределение (Бокса-Мюллера): " + GaussianDistribution());
            Console.WriteLine();
            Console.WriteLine("Нормальное распределение (Зиккрурат-алгоритм): " + ZigguratNormalDistibution());
            Console.ReadKey();
        }


        //равномерное распределение
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

            //var rand_std_normal = Math.Sqrt(-2.0 * Math.Log(u1)) *
            //                    Math.Sin(2.0 * Math.PI * u2);

            //var rand_normal = mu + sigma * rand_std_normal;
            var x = Math.Sqrt(-2.0 * Math.Log(u1)) *
                              Math.Sin(2.0 * Math.PI * u2);

            var rand_normal = 1 / Math.Sqrt(2.0 * Math.PI) *
                                Math.Pow(Math.E, -(x * x) / 2);

            swatch.Stop(); // стоп
            Console.WriteLine("Время выполнения: {0}", swatch.Elapsed);

            return rand_normal;
        }

        //нормальное распределение(зиккурат-алогритм)
        public static double ZigguratNormalDistibution()
        {
            ZigguratGaussianSampler zig = new ZigguratGaussianSampler();
            Random rnd = new Random();
            var res = zig.NextSample();
            if (Math.Abs(res) > 1)
            {
                return rnd.NextDouble();
            }
            return Math.Abs(res);
        }

        //public static void Draw()
        //{
        //    Image newImage = Image.FromFile(@"D:\Скачка\a.png");

        //    Graphics newGraphics = Graphics.FromImage(newImage);

        //    // Alter image.
        //    newGraphics.FillRectangle(new SolidBrush(Color.Black), 100, 50, 100, 100);

        //    Bitmap bitmap = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        //    Graphics g = Graphics.FromImage(bitmap);

        //    Pen pen = new Pen(Brushes.Black);

        //    // Add drawing commands here
        //    g.Clear(Color.White);
        //    int last_x = int.MaxValue;
        //    for (int x = -512; x < 512; x++)
        //    {
        //        double y = x * x;
        //        if (last_x != int.MaxValue)
        //        {
        //            g.DrawLine(pen, new Point(last_x + 512, 1024 - (int)y, new Point(last_x + 512, 1024 - (int)y));
        //        }
        //        last_x = y;
        //    }

        //    bitmap.Save(@"D:\Скачка\b.png", ImageFormat.Png);
        //}
    }
}
