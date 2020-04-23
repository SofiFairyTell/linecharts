using System;
using System.Collections.Generic;
using System.Text;

namespace EqualMethods
{
    public delegate double FunctionX(double x);
    delegate double PointIn(double a, double b);
    public class Methods
	{
        static PointIn Half;
        static double GetHalf(double a,double b)
        {
           return (a + b) * 0.5;
        }
	public double F1(double x)
			{
				return x*Math.Log(x+2)-1;
			}
     public double F2(double x)
			{
            return Math.Pow(x, 3)-Math.Pow(x,2)+2*x-4;
			}
	public double Half_interval(FunctionX F, double a, double b, double E)
			{
            Half = GetHalf;
            double c = Half(a, b);
            if (F(a) * F(b) > 0)
                throw new Exception("Возможно, на этом отрезке нет корней");
            while (Math.Abs(b - a) > E)
				{
                    c = Half(a, b);
                    if (F(c) == 0)
					{
					    return c;	//Корень уравнения
					}
					else
					{
						if (F(c)*F(a) < 0)
						{
							b = c;
						}
						else
						{
							a = c;
						}
					}
            }
            if (Math.Abs(F(a)) <= E) //выбор приближенного значения
                return a;
            else
                return b;
			}
        //первая производная функции
        public double Fdif(FunctionX F,double x)
        {
            double h, fl, fr, fc;

				h = 0.1; // шаг, с которым вычисляем производную
				// приближенно вычисляем первую производную различными способами
				fl = (F(x) - F(x - h)) / h; // левая
				fr = (F(x + h) - F(x)) / h; // правая
				fc = (F(x + h) - F(x - h)) / (2 * h); // центральная
            return fr;
        }
	 	public double N_tangent(FunctionX F,double x, double E)	// "Метод Ньютона" 
		{
            double  x1;
			x1 = x - F(x) / Fdif(F1,x);
			while (Math.Abs(F(x) / Fdif(F,x)) > E)
			{
				x = x1;
				x1 = x - F(x) / Fdif(F,x);
			}
			return x;
		}
	}
}