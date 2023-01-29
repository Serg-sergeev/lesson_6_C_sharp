namespace ProgramClass
{
    public static class UserInput
    {
        public static int GetUserInput(string text = "Введите число: ")
        {
            int userInput;
            string? input;

            do
            {
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out userInput));

            return userInput;
        }

    }

    public static class ActionsWithArrays
    {
        public static double[,] GetRandomTwoDimensionalArray(int row, int colums)
        {
            double[,] array = new double[row, colums];
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (rnd.Next(2) == 1)
                    {
                        array[i, j] = rnd.NextDouble() * 100;
                    }
                    else
                    {
                        array[i, j] = -rnd.NextDouble() * 100;
                    }
                }
            }

            return array;
        }

        public static void PrintArray(double[,] arr, params int[] array)
        {
            array = array ?? new int[0];
            arr = arr ?? new double[0, 0];

            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(" {0,6:F2} ", arr[i, j]);
                    }

                    Console.WriteLine();
                }
            }

            if (array.Length != 0) Console.WriteLine(String.Join(" ", array));

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
    }



}

