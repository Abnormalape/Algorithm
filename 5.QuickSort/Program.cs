using System.Security.Cryptography;

class Program
{
    static void QuickSort(int[] array, int left, int right)
    {
        if (left > right)
        {
            return;
        }

        int pivotIndex = Partition(array, left, right);

        QuickSort(array, left, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, right);
    }

    static int Partition(int[] array, int left, int right)
    {
        int first = left;
        int pivot = array[first];

        left++;

        while (left < right)
        {
            while (array[left] <= pivot)
            {
                left++;
            }
            while (array[right] > pivot)
            {
                right--;
            }

            //두 인덱스가 서로 지나쳤는지 확인.
            if(left > right)
            {
                break;
            }

            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
        if (array[first] > array[right])
        {
            int temp = array[first];
            array[first] = array[right];
            array[right] = temp;

            return right;
        }
        return first;
    }
    static void Main(string[] args)
    {
        int maxValue = 100000;
        Random rand = new Random();
        
        List<int> list = new List<int>();
        for(int i = 0; i < maxValue; i++)
        {
            int number = rand.Next(1,maxValue);
            list.Add(number);
        }
        int[] array = list.ToArray();

        //int[] array = { 5, 2, 8, 4, 1, 7, 3, 6, 9, 10, 15, 13, 14, 12, 17, 16 };
        //int[] array = { 10, 7, 8, 9, 1, 5 };
        //array가 작으면 문제가 생길수도.

        Console.WriteLine($"정렬 전 : {string.Join(", ", array)}");
        QuickSort(array, 0, array.Length-1);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"정렬 후 : {string.Join(", ", array)}");
    }
}