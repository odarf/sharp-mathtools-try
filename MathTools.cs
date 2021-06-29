using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTools
{
    /// <summary>
    /// Аналог класса Math библиотеки FCL
    /// </summary>
    public class MyMath
    {
        const double Pi = Math.PI;
        public int Kinder = 0;
        /// <summary>
        /// Вычисление arctg(x)
        /// </summary>
        /// <param name="x">Аргумент arctg(x)</param>
        /// <returns></returns>
        public static double arctgOld(double x, double EPS)
        {
            double a = -1/x;
            double res = 0;
            int n = 1;
            while (Math.Abs(a) > EPS)
            {
                res += a;
                a *= (-1 * (2 * n - 1)) / ((2 * n + 1) * x * x);
                n++;
            }
            res = (Pi / 2) + res;
            return res;
        }
        public static double arctg(double x, double EPS)
        {
            double a = -1 / x;
            double res = 0;
            int n = 1;
            double x2 = -x * x;
            while (Math.Abs(a) > EPS)
            {
                res += a;
                a *= (2 * n -1) / ((2 * n + 1) *x2);
                n++;
            }
            res = (Pi / 2) + res;
            return res;
        }
        public static double arctgcount(double x, double EPS)
        {
            double a = -1 / x;
            double res = 0;
            int n = 1;
            double x2 = -x * x;
            while (Math.Abs(a) > EPS)
            {
                res += a;
                a *= (2 * n - 1) / ((2 * n + 1) * x2);
                n++;
            }
            res = (Pi / 2) + res;
            return n;
        }
    }
    public class TimeValue
    {
        public delegate double DToD(double arg1);
        public static double EvalTimeDToD(int count, DToD function, double x)
        {
            DateTime start, finish;
            double res = 0;
            start = DateTime.Now;
            for (int i = 1; i < count; i++)
                function(x);
            finish = DateTime.Now;
            res = (finish - start).Milliseconds;
            return res;
        }
    }
}
