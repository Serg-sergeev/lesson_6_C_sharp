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

    public static class ActionsWithNumbers
    {

        public static int GetSumNaturalNumbersMtoN(int m = 0, int n = 10)
        {
            int sum = 0;
            return func(m);

            int func(int m)
            {
                sum += m;
                if (m == n) return sum;
                return func(++m);
            }           
            
        }

    }

}