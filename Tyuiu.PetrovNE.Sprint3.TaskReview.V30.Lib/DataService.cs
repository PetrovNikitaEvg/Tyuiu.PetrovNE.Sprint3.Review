using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PetrovNE.Sprint3.TaskReview.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            double y2;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((((5 * x) + 2.5) / (Math.Sin(x) + 2)) + (2 * x) + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
