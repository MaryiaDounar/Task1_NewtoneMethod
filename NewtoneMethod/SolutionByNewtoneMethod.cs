using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewtoneMethod
{
    public class SolutionByNewtoneMethod
    {
        public static double Execute(double a, int n, double eps)
        {
            if (a < 0)
            {
                string message = String.Format("Parametr 'a' must be positive: {0}", a);
                throw new ArgumentOutOfRangeException(message);
            }
            if (eps < 0)
            {
                string message = String.Format("Parametr 'eps' must be positive: {0}", eps);
                throw new ArgumentOutOfRangeException(message);
            }
            if(a == 0)
            {
                return 0;
            }
                double x1 = 0; 
                double x2 = 1;
                do
                {
                    x1 = x2;
                    x2 = 1d / n * ((n - 1) * x1 + a / Math.Pow(x1, n - 1));
                } while (Math.Abs(x1 - x2) > eps);
            return x2;
        }

    }
}
