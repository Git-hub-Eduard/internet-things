using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public double Diagonal(double a, double b)
        {
            double c;
            c = Math.Sqrt( Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }
        public double Ploch(double x, int n)
        {
            double S = 0;
            for(int i = 1; i<=n; i++)
            {
                S = S + Math.Pow(Math.Sin(x), i);
            }
            return S;
        }
        /// <summary>
        /// Rad_sin
        /// </summary>
        /// <param name="x">real number</param>
        /// <param name="n">natural number</param>
        /// <returns>the value of the sum of the series</returns>
        public double Rad_sin(double x, int n)
        {
            double S = 0;
            for(int i = 1; i<=n; i++)
            {
                S = S + Math.Pow(Math.Sin(x), i);
            }
            return S;
        }
        /// <summary>
        /// Rad_2
        /// </summary>
        /// <param name="x">real number</param>
        /// <param name="n">natural number</param>
        ///  <param name="e">natural number</param>
        /// <returns>the value of the sum of the series</returns>
        public double  Rad_2(double x, int n, int e)
        {
            double S = 1;
            int a = 1;
            double b;
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
                b = Math.Pow(x, 2 * i);
                S = S + (2 * i + 1) * (b / a);
                
            }
            S = Math.Round(S, e);
            return S;
        }
        /// <summary>
        /// Function
        /// </summary>
        /// <param name="x">real number</param>
        ///  <param name="e">natural number</param>
        /// <returns>the value fuction result</returns>
        public double Function(double x, int e)
        {
            double S;
            S = (1 + 2 * Math.Pow(x, 2)) * Math.Exp(Math.Pow(x,2));
            S = Math.Round(S, e);
            return S;
        }
        /// <summary>
        /// Tochne_Zn
        /// </summary>
        /// <param name="s">real number</param>
        ///  <param name="e">natural number</param>
        ///  <param name="f">real number</param>
        /// <returns>the value Error result</returns>
        public double Tochne_Zn(double s, double f, int e)
        {
            double t;
            t = (Math.Abs(s - f) / f) * 100;
            double a = Math.Abs(s - f);
            Console.WriteLine("t =  " + a);
            Console.WriteLine("t =  " + a/f);
            t = Math.Round(t, e);
            return t;
        }
    }
}
