﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Lab3
{
    public class DrawGraphics
    {
        //private double f(double x)
        //{
        //    if (x == 0)
        //    {
        //        return 1;
        //    }

        //    return Math.Sin(x) / x;
        //}

        //public void DrawGraph()
        //{
        //    // Получим панель для рисования
        //    GraphPane pane = zedGraph.GraphPane;
        //    ZedGraph.ze
        //    // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
        //    pane.CurveList.Clear();

        //    // Создадим список точек
        //    PointPairList list = new PointPairList();

        //    double xmin = -50;
        //    double xmax = 50;

        //    // Заполняем список точек
        //    for (double x = xmin; x <= xmax; x += 0.01)
        //    {
        //        // добавим в список точку
        //        list.Add(x, f(x));
        //    }

        //    // Создадим кривую с названием "Sinc", 
        //    // которая будет рисоваться голубым цветом (Color.Blue),
        //    // Опорные точки выделяться не будут (SymbolType.None)
        //    LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.None);

        //    // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
        //    // В противном случае на рисунке будет показана только часть графика, 
        //    // которая умещается в интервалы по осям, установленные по умолчанию
        //    zedGraph.AxisChange();

        //    // Обновляем график
        //    zedGraph.Invalidate();
        //}
    }
}
