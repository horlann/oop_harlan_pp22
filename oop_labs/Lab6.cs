using System;
namespace oop_labs
{
    public class Lab6
    {
        public Lab6()
        {
        }

      public  void SwapSymmetricElements(double[] array)
        {
            int length = array.Length;
            int middle = length / 2;
            for (int i = 0; i < middle; i++)
            {
                int j = length - i - 1;
                double temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        public   double CalculateS(double[] a, double[] b)
        {
            int n = a.Length;
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += (a[i] + b[i]) * (a[i] - b[i]);
            }
            return 2 * sum;
        }

        public  void SortByAbs(double[] array)
        {
            Array.Sort(array, (x, y) => Math.Abs(x).CompareTo(Math.Abs(y)));
        }

        ////////////////////
        ///
        public  void MoveNegativeElements(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int j = 0; j < cols; j += 2)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            int temp = matrix[k, j];
                            matrix[k, j] = matrix[k - 1, j];
                            matrix[k - 1, j] = temp;
                        }
                    }
                }
            }
        }

        public   int[,] CompactMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int[,] result = new int[n, n];
            int row = 0, col = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, i] != 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i && matrix[i, j] != 0)
                        {
                            result[row, col] = matrix[i, j];
                            col++;
                        }
                    }
                    col = 0;
                    row++;
                }
            }
            return result;
        }

        public   int CountRowsInArithmeticProgression(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                bool isProgression = true;
                int diff = matrix[i, 1] - matrix[i, 0];
                for (int j = 2; j < n; j++)
                {
                    if (matrix[i, j] - matrix[i, j - 1] != diff)
                    {
                        isProgression = false;
                        break;
                    }
                }
                if (isProgression)
                {
                    count++;
                }
            }
            return count;
        }





    }
}

