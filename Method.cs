using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise_2
{
    internal class Method
    {
        public static int OperatorAdd(int x, int y)
        {
            return x + y;
        }
        public static int OperatorSubstract(int x, int y)
        {
            return x - y;
        }
        
        public static int OperatorMultiply(int x, int y)
        {
            return (x * y);
        }
        public static int OperatorDevide(int x, int y) 
        { 
            if (y == 0)
            {
                return 0;
            }
            return x/y;
        }

        public static int OperatorModulo(int x, int y)
        {
            return (x%y);
        }

        public static int OperatorSum(params int[] parameters) //integer array here is called "parameters"
        {
            int sum = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                sum += parameters[i];
            }
            return sum;
        }

    }
}


   
