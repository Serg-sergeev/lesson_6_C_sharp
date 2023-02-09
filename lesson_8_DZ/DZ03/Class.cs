namespace ProgramClass
{

    public static class UserInput
    {

        public static int GetInputNumber(string text = "Введите число")
        {
            string? input;
            int result;

            do
            {
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out result));

            return result;
        }

    }

    public static class ActionsWithArray
    {

        public static void Print(int[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }

        }

        public static int[,] GetRandom(int row, int columns, int minValue = 0, int maxValue = 10)
        {

            Random rnd = new Random();
            int[,] array = new int[row, columns];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rnd.Next(minValue, maxValue);
                }
            }

            return array;

        }

        public static int[,] GetSpirallyFilledArray(int row, int columns, int minValue = 0, int maxValue = 100)
        {
            int[,] array = new int[row, columns];


            for (int i = 0, j = 1; i < row / 2; i++, j++)
            {

                for (int e = j - 1; e < columns - j + 1; e++)
                {
                    array[i, e] = minValue++;
                }

                for (int e = j; e < row - j + 1; e++)
                {
                    array[e, columns - i - 1] = minValue++;
                }

                for (int e = columns - j - 1; e > i; e--)
                {
                    array[columns - j, e] = minValue++;
                }

                for (int e = row - j; e > j - 1; e--)
                {
                    array[e, i] = minValue++;
                }

            }

            if (row % 2 == 1 || columns % 2 == 1) array[row / 2, columns / 2] = minValue++;


            return array;
        }

        public static void GetIndexElementsArray(int[,,] array)
        {

            for (int i = 0; i < array.GetLength(2); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    for (int n = 0; n < array.GetLength(1); n++)
                    {
                        Console.Write($"{array[i, j, n]} " + $"({i}, {j}, {n})\t");
                    }

                    Console.WriteLine("\t");
                }

                Console.WriteLine();
            }

        }

        public static int[,] GetCompositionMatrix(int[,] arrayOne, int[,] arrayTwo)
        {

            int[,] array = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

            if (arrayOne.GetLength(1) != arrayTwo.GetLength(0))
            {
                Console.WriteLine("Данные матрицы нельзя перемножать!");

                return array;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int n = 0; n < arrayOne.GetLength(1); n++)
                    {
                        array[i, j] += arrayOne[i, n] * arrayTwo[n, j];
                    }

                }
            }

            return array;

        }

    }

}