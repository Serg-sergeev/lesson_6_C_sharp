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

        public static void FindElementArray(int[,] array, int rowIndex, int ColumnsIndex)
        {

            if (rowIndex >= array.GetLength(0) || ColumnsIndex >= array.GetLength(1))
            {
                Console.WriteLine("Элемент c такими индексами не найден!");
            }
            else
            {
                Console.WriteLine($"Элемент найден: {array[rowIndex, ColumnsIndex]}");
            }

        }
    }

}
