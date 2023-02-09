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

        public static void Print(int[,,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int n = 0; n < array.GetLength(2); n++)
                    {
                        Console.Write($"{array[i, j, n]}\t");
                    }

                    Console.WriteLine("\t");
                }

                Console.WriteLine();
            }

        }

        public static int[,,] GetRandom(int count, int columns, int row, int minValue = 0, int maxValue = 10)
        {

            Random rnd = new Random();
            int[,,] array = new int[count, row, columns];

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    for (int n = 0; n < columns; n++)
                    {
                        array[i, j, n] = rnd.Next(minValue, maxValue);
                    }
                }
            }

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
        
    }

}