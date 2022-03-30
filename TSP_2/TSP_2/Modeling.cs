using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP_2
{
    class Modeling
    {
        Random rnd = new Random();

        public List<(double, double)> Start(double time, double lambda, double mt, double sigma)
        {
            //Random rnd = new Random();
            double T = 0;
            double N = 0;
            List<(double,double)> Total = new List<(double,double)>();
            while (T <= time) 
            {
                double r = rnd.NextDouble();
                double tau = -1 / lambda * Math.Log(r);
                double x = GetCountOfCarriages(mt, sigma);
                Console.WriteLine(x);
                T += tau;
                N += x;
                (double, double) value = (Math.Round(T), x);
                Total.Add(value);
            }
            return Total;
        }

        public double GetCountOfCarriages(double mk, double sigma)
        {
            //Random rnd = new Random();
            double r1 = rnd.NextDouble();
            double r2 = rnd.NextDouble();
            double z = Math.Sqrt(-2 * Math.Log(r1)) * Math.Cos(2 * Math.PI * r2);
            return Math.Round(mk + sigma * z);
        }
    }
}
