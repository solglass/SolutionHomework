using System;

namespace Homework
{
    public class OperationsWithVariables
    {
        public static double Solve5AplBSqDivByBMinusA(int a, int b)
        {
            double c = 0;
            c = (5 * a + b * b / (b - a));
            return c;
        }

        public static int[] SwapAAndB(int a, int b)
        {
            int[] result = new int[2];
            int c = 0;
            c = a;
            a = b;
            b = c;
            result[0] = a;
            result[1] = b;
            return result;
        }
        public static int[] CalculateDivAndMod(int a, int b)
        {
            int[] result = new int[2];
            result[0] = a / b;
            result[1] = a % b;
            return result;
        }
            public static double SolveLinearEquation(double a, double b, double c)
        {
            double x = 0;
            x = ((c - b) / a);
            return x;
        }
            public static double[] CalclutateLinearEquationFromTwoPoints(double x1, double x2, double y1, double y2)
        {
            double[] result = new double[2];
            double k = 0;
            double b = 0;
            if (x1 - x2 == 0)
                throw new Exception("y = 0, which is not supported");
            else
            {
                k = (y1 - y2) / (x1 - x2);
            }
            b = y2 - k * x2;
            result[0] = k;
            result[1] = b;
            return result;
        }


    }
}
