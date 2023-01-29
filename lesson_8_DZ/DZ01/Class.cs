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
    
        public static void SortingRowDescendingOrder(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int temp = min = array[i, j];
                    
                    for (int count = 0; count < array.GetLength(1) - 1; count++)
                    {
                        if (array[i + 1, j + 1] < array[i, j])
                        {
                            if (count == array.GetLength(1) - 2) break;
                            min = array[i + 1, j + 1];
                        }
                    }
                    
                    if (array[i + 1, j + 1] > array[i, j])
                    {
                        
                    }
                }
            }
        }
    }
}

