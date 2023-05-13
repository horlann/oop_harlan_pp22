using System;
namespace oop_labs
{
    public class Lab7
    {
        public Lab7()
        {
            INumberOperations number1 = new IntegerNumber(123456);
            Console.WriteLine("Digit sum: " + number1.GetDigitSum());
            Console.WriteLine("Zero count: " + number1.GetZeroCount());

            INumberOperations number2 = new DoubleNumber(1234.56);
            Console.WriteLine("Digit sum: " + number2.GetDigitSum());
            Console.WriteLine("Zero count: " + number2.GetZeroCount());
        }
    }
}

interface INumberOperations
{
    int GetDigitSum();
    int GetZeroCount();
}

class IntegerNumber : INumberOperations
{
    private int number;

    public IntegerNumber(int number)
    {
        this.number = number;
    }

    public int GetDigitSum()
    {
        int sum = 0;
        int temp = Math.Abs(number);
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        return sum;
    }

    public int GetZeroCount()
    {
        int count = 0;
        int temp = Math.Abs(number);
        while (temp > 0)
        {
            if (temp % 10 == 0)
            {
                count++;
            }
            temp /= 10;
        }
        return count;
    }
}

class DoubleNumber : INumberOperations
{
    private double number;

    public DoubleNumber(double number)
    {
        this.number = number;
    }

    public int GetDigitSum()
    {
        int sum = 0;
        string str = number.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                sum += int.Parse(str[i].ToString());
            }
        }
        return sum;
    }

    public int GetZeroCount()
    {
        int count = 0;
        string str = number.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '0')
            {
                count++;
            }
        }
        return count;
    }
}
