using System;
using System.Drawing;

class TSMatrix
{
    private int[,] data; // Матриця
    private int size;    // Розмірність матриці
    public TSMatrix(int size)
    {
        this.size = size;
        data = new int[size, size];
    }
    // Конструктори
    public TSMatrix()
    {
        size = 0;
        data = null;
    }

    public TSMatrix(int[,] data)
    {
        size = data.GetLength(0);
        this.data = data;
    }

    public TSMatrix(TSMatrix other)
    {
        size = other.size;
        data = (int[,])other.data.Clone();
    }

    // Методи для введення/виведення даних
    public void Input()
    {
        Console.WriteLine("Введіть розмірність матриці:");
        size = int.Parse(Console.ReadLine());

        data = new int[size, size];

        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"[{i}, {j}]: ");
                data[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void Output()
    {
        Console.WriteLine("Матриця:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Методи для знаходження найбільшого/найменшого елемента
    public int GetMax()
    {
        int max = data[0, 0];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (data[i, j] > max)
                {
                    max = data[i, j];
                }
            }
        }
        return max;
    }

    public int GetMin()
    {
        int min = data[0, 0];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (data[i, j] < min)
                {
                    min = data[i, j];
                }
            }
        }
        return min;
    }

    // Метод для знаходження суми елементів
    public int GetSum()
    {
        int sum = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                sum += data[i, j];
            }
        }
        return sum;
    }

    // Перевантаження операторів + (додавання матриць), - (віднімання матриць)
    public static TSMatrix operator +(TSMatrix a, TSMatrix b)
    {
        TSMatrix result = new TSMatrix(a.size);
        for (int i = 0; i < a.size; i++)
        {
            for (int j = 0; j < a.size; j++)
            {
                result.data[i, j] = a.data[i, j] + b.data[i, j];
            }
        }
        return result;
    }


    public static TSMatrix operator -(TSMatrix a, TSMatrix b)
    {
        TSMatrix result = new TSMatrix(a.size);
        for (int i = 0; i < a.size; i++)
        {
            for (int j = 0; j < a.size; j++)
            {
                result.data[i, j] = a.data[i, j] - b.data[i, j];
            }
        }
        return result;
    }
    // властивість розмірності матриці
    public int Size
    {
        get { return size; }
    }
    // індексатор для доступу до елементів матриці
    public double this[int i, int j]
    {
        get { return data[i, j]; }
        set {   }
    }

}

// клас-нащадок TMSMatrix
class TMSMatrix : TSMatrix
{
    // конструктори
    public TMSMatrix() : base() { }
    public TMSMatrix(int size) : base(size) { }
    public TMSMatrix(TSMatrix other) : base(other) { }

    // транспонування матриці
    public void Transpose()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = i + 1; j < Size; j++)
            {
                double temp = this[i, j];
                this[i, j] = this[j, i];
                this[j, i] = temp;
            }
        }
    }

    // множення матриці на матрицю
    public static TMSMatrix operator *(TMSMatrix a, TMSMatrix b)
    {
        if (a.Size != b.Size)
        {
            throw new ArgumentException("Matrix dimensions do not match");
        }

        TMSMatrix result = new TMSMatrix(a.Size);

        for (int i = 0; i < a.Size; i++)
        {
            for (int j = 0; j < a.Size; j++)
            {
                for (int k = 0; k < a.Size; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }

    // множення матриці на число
    public static TMSMatrix operator *(TMSMatrix a, double scalar)
    {
        TMSMatrix result = new TMSMatrix(a.Size);

        for (int i = 0; i < a.Size; i++)
        {
            for (int j = 0; j < a.Size; j++)
            {
                result[i, j] = a[i, j] * scalar;
            }
        }

        return result;
    }
}