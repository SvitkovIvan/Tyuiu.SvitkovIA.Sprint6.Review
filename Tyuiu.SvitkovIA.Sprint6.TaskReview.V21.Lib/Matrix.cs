using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.SvitkovIA.Sprint6.TaskReview.V21.Lib
{
    public class Matrix 
    {
        public int  GetMatrix (int[,] array, int n1, int n2, int c, int k, int l)
        {
            
            if (n1 >= n2 || k > l || k < 0 || l >= array.GetLength(0) || c < 0 || c >= array.GetLength(1))
            {
                
            }

            int maxElement = int.MinValue;
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i == k)
                {
                    count = 0;
                }

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == c)
                    {
                        count += 1;
                    }

                    if (count >= 2)
                    {
                        array[i, j] = array[i, j - 1] + array[i, j - 2];
                    }

                    if (i >= k && i <= l && i % 2 != 0 && array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }
                }
            }

            return maxElement;
        }
    }
}