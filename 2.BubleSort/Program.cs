class Program
{
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; ++i)
        {
            for (int j = 0; j < array.Length - 1 - i; ++j)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 8, 4, 1,7,3,6,9,10,15,13,14,12,17,16 };
        Console.WriteLine($"정렬 전 배열 : {string.Join(",", array)}");
        BubbleSort(array);
        Console.WriteLine($"정렬 후 배열 : {string.Join(",", array)}");
    }
}
