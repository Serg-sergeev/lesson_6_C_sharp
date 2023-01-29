namespace ProgramClass
{
    public static class UserInput
    {
        public static int GetUserInput(string text)
        {
            int number;
            string? input;

            do
            {
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out number));

            return number;
        }
    }

    public static class OperationEquations
    {
        public static int[] GetIntersectionPoint(int k1, int k2, int b1, int b2)
        {
            int[] array = new int[2] {0 , 0};
            if (k1 == k2 && b1 == b2)
            {
                Console.WriteLine("Прямые совпадают!");
                return  array;
            }
            if (k1 - k2 == 0)
            {
                Console.WriteLine("Прямые параллельны!");
                return array;
            }
            array[0] = (b2 - b1) / (k1 - k2);
            array[1] = array[0] * k1 + b1;

            return array;
        }
    }
}


