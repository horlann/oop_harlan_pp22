//Написати програму, що реалізує множення двох матриць, заданих як двовимірні масиви.
//    У програмі передбачити два методи: метод множення матриць (на вхід дві матриці, значення, що
//повертається – матриця), метод виводу матриці на екран. Завдання також виконати за
//допомогою колекцій LinkedList<LinkedList<T>>.

using System;
using System.Collections.Generic;

class MatrixMultiplier
{
    public static LinkedList<LinkedList<T>> Multiply<T>(LinkedList<LinkedList<T>> matrix1, LinkedList<LinkedList<T>> matrix2)
    {
        int rows1 = matrix1.Count;
        int columns1 = matrix1.First.Value.Count;
        int rows2 = matrix2.Count;
        int columns2 = matrix2.First.Value.Count;

        if (columns1 != rows2)
            throw new ArgumentException("The number of columns in the first matrix must match the number of rows in the second matrix.");

        LinkedList<LinkedList<T>> result = new LinkedList<LinkedList<T>>();

        for (int i = 0; i < rows1; i++)
        {
            LinkedList<T> row = new LinkedList<T>();

            for (int j = 0; j < columns2; j++)
            {
                T value = default(T);

                for (int k = 0; k < columns1; k++)
                {
                    T element1 = matrix1.ElementAt(i).ElementAt(k);
                    T element2 = matrix2.ElementAt(k).ElementAt(j);
                    value += (dynamic)element1 * element2;
                }

                row.AddLast(value);
            }

            result.AddLast(row);
        }

        return result;
    }

    public static void PrintMatrix<T>(LinkedList<LinkedList<T>> matrix)
    {
        foreach (LinkedList<T> row in matrix)
        {
            foreach (T element in row)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}

class Lab8
{
   public  void Execute()
    {
        LinkedList<LinkedList<int>> matrix1 = new LinkedList<LinkedList<int>>();
        LinkedList<LinkedList<int>> matrix2 = new LinkedList<LinkedList<int>>();

        // Заповнення першої матриці
        matrix1.AddLast(new LinkedList<int>(new int[] { 1, 2, 3 }));
        matrix1.AddLast(new LinkedList<int>(new int[] { 4, 5, 6 }));
        matrix1.AddLast(new LinkedList<int>(new int[] { 7, 8, 9 }));

        // Заповнення другої матриці
        matrix2.AddLast(new LinkedList<int>(new int[] { 1, 2 }));
        matrix2.AddLast(new LinkedList<int>(new int[] { 3, 4 }));
        matrix2.AddLast(new LinkedList<int>(new int[] { 5, 6 }));

        // Множення матриць
        LinkedList<LinkedList<int>> result = MatrixMultiplier.Multiply(matrix1, matrix2);

        // Виведення результату
        MatrixMultiplier.PrintMatrix(result);
    }
}
