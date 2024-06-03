class Program
{
    // 이진 탐색 함수.
    // 재귀 함수.
    // array: 자료 집합 배열.
    // target: 찾으려는 수.
    // start: array에서 검색을 시작할 인덱스(최소 인덱스).
    // end: array에서 검색을 마무리할 인덱스(최대 인덱스).
    // 예: Up/Down 게임을 생각하면 알고리즘 이해가 쉬움.
    // trycount
    static int BinarySearch(int[] array, int target, int start, int end, ref int tryCount)
    {
        if (start > end)
        {
            return -1;
        }
        int mid = (start + end) / 2;
        tryCount++;

        if (array[mid] == target)
        {
            return mid;
        }
        if (array[mid] > target)
        {
            return BinarySearch(array, target, start, mid-1, ref tryCount);
        }
        return BinarySearch(array,target, mid+1, end, ref tryCount);

    }
    static void Main(string[] args)
    {
        int[] array = new int[1000];
        for (int ix = 0; ix < array.Length; ++ix)
        {
            array[ix] = ix + 1;
        }

        int target = 774;
        int tryCount = 0;
        int index = BinarySearch(array, target, 0, array.Length - 1, ref tryCount);

        // 검색 실패.
        if (index < 0)
        {
            Console.WriteLine($"값 {target}을 찾지 못했습니다.");
        }

        // 검색 성공.
        else if (index >= 0 && index < array.Length)
        {
            Console.WriteLine($"값 {target}를 찾았고, 인덱스는 {index}입니다.");
            Console.WriteLine($"찾는데 시도한 횟수는 {tryCount}번 입니다.");
        }


        Console.ReadKey();

    }
}
