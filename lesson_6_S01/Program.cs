int[] arr = { 1, 2, 3, 4, 5 };

void ReverseArray(int[] array)
{
    int len = array.Length;
    
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[len - 1 - i];
        array[len - 1 - i] = temp;
    }
}

ReverseArray(arr);

Console.WriteLine(string.Join(" ", arr));