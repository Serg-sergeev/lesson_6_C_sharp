namespace ProgramClass
{

    public static class UserInput
    {

        public static int GetUserNumber(string text = "Введите число: ")
        {
            int userInput;
            string? input;

            do
            {
                Console.Write(text);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out userInput));

            return userInput;
        }
    }

    public static class ActionsWithArrays
    {

        public static void PrintArrayIJ(int[,] array)
        {
            //array = array ?? null;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }
        }

        public static int[,] GetRandomArray(int row, int columns, int minValue = 0, int maxValue = 10)
        {
            int[,] array = new int[row, columns];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(minValue, maxValue);
                }
            }

            return array;
        }

        public static double[] GetArithmeticMeanCulumnsArray(int[,] array)
        {
            double[] resArray = new double[array.GetLength(1)];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                double temp = 0;

                for (int j = 0; j < array.GetLength(0); j++)
                {
                    temp += array[j, i];
                }

                resArray[i] = Math.Round(temp / array.GetLength(0), 2);
            }

            return resArray;
        }

        public static int[,] SortingRowDescendingOrder(int[,] array)
        {
            int columnsLong = array.GetLength(1);
            int rowLong = array.GetLength(0);

            for (int i = 0; i < rowLong; i++)
            {

                for (int j = 0; j < columnsLong - 1; )
                {
                    
                    if (array[i, j] < array[i, j + 1])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                        j = 0;
                    }
                    else j++;
                }
            }

            return array;
        }

        public static int GetRowSmallestSumElements (int[,] array)
        {
            int[] resultSum = new int[array.GetLength(0)];
            int index = -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    resultSum[i] += array[i, j];
                }
            }

            int min = resultSum[0];

            for (int i = 0; i < resultSum.Length; i++)
            {
                if (resultSum[i] <= min) 
                {
                    min = resultSum[i];
                    index = i + 1;
                }
            }

            Console.WriteLine(string.Join(" ", resultSum));

            return index;
        }

    }
}

