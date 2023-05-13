using System.ComponentModel;
using System.Drawing;
using oop_labs;

Console.WriteLine("Hello, World choose lab");
int labNumber = int.Parse(Console.ReadLine());

switch (labNumber)
{
    case 1:
        TSMatrix matrix = new TSMatrix();
        matrix.Input();
   
        matrix.Output();
        Console.WriteLine("Max "+matrix.GetMax()
          );
        Console.WriteLine("Min " + matrix.GetMin()
          );
        Console.WriteLine("Sum " + matrix.GetSum()
          );
        break;
    case 2:
        Lab6 lab6= new Lab6();
        double[] array1 ={5.0, 4, 8, 9};
        double[] array2 = { 5.0, 4, 8, 9 };
        int[,] matrixArray = { {5,7 } , { 7, 7 } , { 6, 9 }, { 2, 4 } };

        Console.WriteLine("Choose task ");
        int task = int.Parse(Console.ReadLine());
        switch (task) {
            case 1:
                foreach (double num in array1) {
                    Console.Write(num);
                    Console.Write(" ");

                }

                lab6.SwapSymmetricElements(array1);
                Console.WriteLine(" ");

                foreach (double num in array1)
                {
                    Console.Write(num);
                    Console.Write(" ");
                }
                break;
            case 2:
                foreach (double num in array1)
                {
                    Console.Write(num);
                    Console.Write(" ");

                }
                Console.WriteLine(" ");
                foreach (double num in array2)
                {
                    Console.Write(num);
                    Console.Write(" ");

                }
                lab6.SwapSymmetricElements(array1);
                Console.WriteLine(" ");
                Console.WriteLine(lab6.CalculateS(array1, array2)
);

                

                break;
            case 3:
                foreach (double num in array1)
                {
                    Console.Write(num);
                    Console.Write(" ");

                }

                lab6.SortByAbs(array1);
                Console.WriteLine(" ");

                foreach (double num in array1)
                {
                    Console.Write(num);
                    Console.Write(" ");
                }
                break;
            case 4:
                for (int i = 0; i < matrixArray.Length; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(matrixArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                lab6.MoveNegativeElements(matrixArray);
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(matrixArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                break;
            case 5:
                Console.WriteLine(lab6.CompactMatrix(matrixArray)
);

                break;
            case 6:
                Console.WriteLine(lab6.CountRowsInArithmeticProgression(matrixArray));

                break;
        }
        /////
        ///

        break;
    case 3:
        Lab7 lab7 = new Lab7();
        break;
}



