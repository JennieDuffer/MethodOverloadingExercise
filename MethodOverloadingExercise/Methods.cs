using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add( decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isTrue)
        {
            var sum = 0;
            var response = "";
            if (isTrue)
            {
                sum = a + b;

                if (sum == 1)
                    response = $"{sum} dollar";

                else
                {
                    response = $"{sum} dollars";
                }
            }
            return response;
        }
           

    }
}
