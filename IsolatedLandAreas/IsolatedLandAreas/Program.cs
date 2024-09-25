using System;

namespace IsolatedLandAreas
{
    class Program
    {
        public static int CountIsolatedLandAreas(string[] map)
        {
            int rows = map.Length;
            int cols = map[0].Length;
            bool[,] visited = new bool[rows, cols];
            int isolatedLandAreas = 0;

            // Directions for moving up, down, left, and right
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            void DFS(int x, int y)
            {
                visited[x, y] = true;

                // Explore all four possible directions
                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dx[i];
                    int newY = y + dy[i];

                    if (newX >= 0 && newX < rows && newY >= 0 && newY < cols &&
                        map[newX][newY] == 'L' && !visited[newX, newY])
                    {
                        DFS(newX, newY);
                    }
                }
            }

            // Traverse the grid
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (map[i][j] == 'L' && !visited[i, j])
                    {
                        // Start a new DFS for a new isolated land area
                        DFS(i, j);
                        isolatedLandAreas++;
                    }
                }
            }

            return isolatedLandAreas;
        }

        static void Main(string[] args)
        {
            string[] map1 = {
                "#####",
                "#LL#L",
                "#LL#L",
                "#L###",
                "#####"
            };

            string[] map2 = {
                "####",
                "#LL#",
                "#LL#",
                "#LL#",
                "####"
            };

            string[] map3 = {
                "#####",
                "#L#L#",
                "#L#L#",
                "#L#L#",
                "#####"
            };

            Console.WriteLine(CountIsolatedLandAreas(map1)); // Output: 2
            Console.WriteLine(CountIsolatedLandAreas(map2)); // Output: 1
            Console.WriteLine(CountIsolatedLandAreas(map3)); // Output: 3
        }
    }
}