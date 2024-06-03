public class Program
{
    static void SelectionSort(int[] array)
    {
        for(int i = 0 ; i < array.Length -1; ++i)
        {
            int minIndex = i;
            for(int j = i+1 ;j < array.Length;++j)
            {
                if (array[minIndex] > array[j])
                {
                    minIndex = j;
                }
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 8, 4, 1, 7, 3, 6, 9, 10, 15, 13, 14, 12, 17, 16 };
        Console.WriteLine($"정렬 전 배열 : {string.Join(",",array)}");

        SelectionSort(array);

        Console.WriteLine($"정렬 후 배열 : {string.Join(",", array)}");

        Console.ReadKey();
    }
}