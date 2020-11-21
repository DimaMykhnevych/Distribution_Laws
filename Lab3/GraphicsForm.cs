using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Lab3
{
    public partial class GraphicsForm : Form
    {
        private int _a;
        private int _b;
        public GraphicsForm()
        {
            InitializeComponent();
            this.Size = new Size(1100, 820);
        }
        

        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            
            DrawExp();
            DrawGauss();
           
            richTextBox.Text += String.Format("Экспоненциальное распределение: {0} \n", Distributions.ExponentialDistribution());
            richTextBox.Text += String.Format("Нормальное распределение (Бокса-Мюллера): {0} \n", Distributions.GaussianDistribution());
            richTextBox.Text += String.Format("Нормальное распределение (Зиккурат-алгоритм): {0} \n", Distributions.ZigguratNormalDistibution());
        }

        public ZedGraph.ZedGraphControl zedGraph;

        private double f_un(double x, double a, double b)
        {
            return 1 / (b - a);
        }


        public double f_ex(double x)
        {            
            return -Math.Log(x);
        }

        public double f_norm(double x)
        {
            return 1/Math.Sqrt(2.0 * Math.PI) *
                                Math.Pow(Math.E, -(x*x)/2);
        }

        public void DrawUniform(double a, double b)
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = a;
            double xmax = b;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.1)
            {
                // добавим в список точку
                list.Add(x, f_un(x, a, b));
            }

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraph.AxisChange();

            // Обновляем график
            zedGraph.Invalidate();
        }

        public void DrawExp()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph2.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = 0;
            double xmax = 20;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.1)
            {
                // добавим в список точку
                list.Add(x, f_ex(x));
            }

            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

           
            zedGraph2.AxisChange();

            // Обновляем график
            zedGraph2.Invalidate();
        }

        public void DrawGauss()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraph3.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            double xmin = -1;
            double xmax = 1;

            // Заполняем список точек
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                // добавим в список точку
                list.Add(x, f_norm(x));
            }

            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);


            zedGraph3.AxisChange();

            // Обновляем график
            zedGraph3.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _a = Convert.ToInt32(firstValue.Text);
            _b = Convert.ToInt32(secondValue.Text);
            DrawUniform(_a, _b);
            richTextBox.Text += String.Format("Равномерное распределение: {0} \n", Distributions.UniformDistribution(_a, _b));
        }
    }
}
