using System.Data;
using System.Security;
using System.Security.Cryptography.X509Certificates;

class Position
{
    public int Row { get; set; }
    public int Column { get; set; }
}



public class Map
{
    private char[,] map;

    private int rows;
    private int cols;

    private Position[] direction =
    {
            new Position(){Row = -1, Column = 0},
            new Position(){Row = 1, Column = 0},
            new Position(){Row = 0, Column = -1},
            new Position(){Row = 0, Column = 1}
    };

    private int[] directionRow = { -1, 1, 0, 0 };
    private int[] directioncol = { 0, 0, -1, 1 };


    public Map(char[,] map)
    {
        this.map = map;
        rows = map.GetLength(0);
        cols = map.GetLength(1);
    }

    public void BreadthFirstSearch(int startRow, int startColumn)
    {
        bool[,] visited = new bool[rows, cols];

        Queue<Position> queue = new Queue<Position>();

        visited[startRow, startColumn] = true;

        queue.Enqueue(new Position { Row = startRow, Column = startColumn });

        while(queue.Count > 0)
        {
            Position current = queue.Dequeue();

            Console.WriteLine($"방문한 위치: ({current.Row},{current.Column})");

            for (int i = 0; i < direction.Length; i++)
            {
                int newRow = current.Row + direction[i].Row;

                int newColumn = current.Column + direction[i].Column;

                if((newRow >=0 && newRow < rows)&&(newColumn >= 0 && newColumn < cols))
                {
                    if (visited[newRow, newColumn] == false)
                    {
                        visited[newRow, newColumn] = true;
                        queue.Enqueue(new Position { Row = newRow, Column = newColumn});
                    }

                }
            }
        }
    }

    public void Print()
    {
        for(int i = 0;i < map.GetLength(0);i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                Console.Write($"({map[i,j]})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        // 맵을 2차원 배열로 생성.
        char[,] map =
        {
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
            {'#', '.', '.', '.', '#', '.', '.', '.', '.', '#'},
            {'#', '.', '#', '.', '#', '.', '#', '#', '.', '#'},
            {'#', '.', '#', '.', '.', '.', '#', '#', '.', '#'},
            {'#', '.', '#', '#', '#', '#', '#', '#', '.', '#'},
            {'#', '.', '.', '.', '#', '.', '.', '.', '.', '#'},
            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
        };

        Map searchMap = new Map(map);

        searchMap.Print();

        searchMap.BreadthFirstSearch(1, 1);




        Console.ReadKey();
    }
}
