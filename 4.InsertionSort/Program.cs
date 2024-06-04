using System.Runtime.ExceptionServices;

class Program
{
    static void InsertionSort(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            int keyvalie = array[i];
            for (int j = i; j >0 ; j--)
            {
                if (array[j-1] > keyvalie)
                {
                    array[j] = array[j-1];
                    array[j-1] = keyvalie;  
                }
            }
        }
    }
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 8, 4, 1, 7, 3, 6, 9, 10, 15, 13, 14, 12, 17, 16 };
        Console.WriteLine($"정렬 전: {string.Join(", ",array)}");

        InsertionSort(array);

        Console.WriteLine($"정렬 후: {string.Join(", ", array)}");
    }
}
