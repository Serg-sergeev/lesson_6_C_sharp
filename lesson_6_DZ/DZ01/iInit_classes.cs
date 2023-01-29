namespace InitClases
{

    public static class UserInput
    {

        public static int[] GetSetOfNumbers()
        {

            bool res = false;

            while (true)
            {

                Console.WriteLine("Введите числа через пробел: ");
                string[]? input = Console.ReadLine()!.Split(" ");
                int[] arr = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    res = int.TryParse(input[i], out arr[i]);
                    
                    if (res == false)
                    {
                        Console.WriteLine("Попробуйте еще раз: ");
                        break;
                    }
                }

                if (res == true) return arr;
            }
        }

        public static int GetCountInputPositivNumbers(bool random = false, params int[] array)
        {
            if (random)
            {
                array = GetSetOfNumbers();
                return GetPositivNumber(array);
            }
            else
            {
                return GetPositivNumber(array);
            }

            int GetPositivNumber(int[] array)
            {
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0) count++;
                }

                return count;
            }
        }
        public static void Print(int[] array)
        {
            Console.WriteLine(String.Join("\t", array));
        }
    }

}