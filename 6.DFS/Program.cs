// 맵 클래스.
public class Map
{
    // 2차원 배열로 맵을 저장.
    private int[,] map;

    // 행(row) 수.
    private int rows;

    // 열(column)의 수.
    private int columns;

    // 메시지 (공개 메소드) - 인터페이스.
    // 생성.
    public Map(int[,] map)
    {
        // 맵 설정.
        this.map = map;

        // 행의 수 저장.
        rows = map.GetLength(0);

        // 열의 수 저장.
        columns = map.GetLength(1);
    }

    // 탐색.
    // row: 이번에 방문할 행의 값.
    // column: 이번에 방문할 열의 값.
    // visited: 방문한 위치를 표기하는 배열.
    public void DepthFirstSearch(int row, int column, bool[,] visited)
    {
        // 방문한 위치 표시.
        visited[row, column] = true;

        // 현재 위치 출력.
        Console.WriteLine($"방문한 셀: ({row}, {column})");

        // 이동.
        int[] directionRow = { -1, 1, 0, 0 };       // 상하.
        int[] directionColumn = { 0, 0, -1, 1 };    // 좌우.

        // 상하좌우 방향에 대해 재귀적(스택 사용)으로 DepthFirstSeach 함수 호출.
        for (int ix = 0; ix < directionRow.Length; ++ix)
        {
            // 새로 방문할 행의 위치 계산.
            int newRow = row + directionRow[ix];

            // 새로 방문할 열의 위치 계산.
            int newColumn = column + directionColumn[ix];

            // 위에서 계산한 위치가 방문이 가능한지 확인 후, 방문하지 않았으면 방문.
            if ((newRow >= 0 && newRow < rows)
                && (newColumn >= 0 && newColumn < columns))
            {
                // 방문하지 않았는지도 추가로 확인.
                if (visited[newRow, newColumn] == false)
                {
                    DepthFirstSearch(newRow, newColumn, visited);
                }
            }
        }
    }

    // 출력.
    public void Print()
    {
        // 2차원 배열을 2중 루프로 순회하면서 맵을 출력.
        for (int ix = 0; ix < map.GetLength(0); ++ix)
        {
            for (int jx = 0; jx < map.GetLength(1); ++jx)
            {
                Console.Write($"{map[ix, jx]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }

    // 메소드 (내부 함수).
}
public class Program
{
    static void Main(string[] args)
    {
        // 맵 생성.
        int[,] map =
        {
            { 1, 1, 0, 0 },
            { 0, 1, 1, 0 },
            { 0, 0, 1, 0 },
            { 1, 0, 1, 1 }
        };

        // 맵 객체 생성.
        Map searchMap = new Map(map);

        // 맵 출력.
        searchMap.Print();

        // 방문 여부를 저장할 배열 초기화.
        bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];

        // 시작 위치 출력.
        Console.WriteLine($"깊이 우선 탐색의 시작 위치 (0, 0)");

        // 시작 위치(0,0)에서 부터 탐색 시작.
        searchMap.DepthFirstSearch(0, 0, visited);

        Console.ReadKey();
    }
}